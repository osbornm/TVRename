// 
// Main website for TVRename is http://tvrename.com
// 
// Source code available at http://code.google.com/p/tvrename/
// 
// This code is released under GPLv3 http://www.gnu.org/licenses/gpl.html

namespace TVRename
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public class ActionCopyMoveRename : Item, Action, ScanListItem
    {
        #region Op enum

        public enum Op
        {
            Copy,
            Move,
            Rename
        }

        #endregion

        public FileInfo From;
        public Op Operation;
        public FileInfo To;
        private double _Percent;

        public ActionCopyMoveRename(Op operation, FileInfo from, FileInfo to, ProcessedEpisode ep)
        {
            this.PercentDone = 0;
            this.Episode = ep;
            this.Operation = operation;
            this.From = from;
            this.To = to;
        }

        #region Action Members

        public bool Done { get; set; }
        public bool Error { get; set; }
        public string ErrorText { get; set; }

        public string Name
        {
            get { return this.IsMoveRename() ? "Move" : "Copy"; }
        }

        public string ProgressText
        {
            get { return this.To.Name; }
        }

        public double PercentDone
        {
            get { return this.Done ? 100.0 : this._Percent; }
            set { this._Percent = value; }
        }

        // 0.0 to 100.0
        public long SizeOfWork
        {
            get { return this.QuickOperation() ? 10000 : this.SourceFileSize(); }
        }

        public bool Go(TVSettings settings, ref bool pause, TVRenameStats stats)
        {
            // read NTFS permissions (if any)
            System.Security.AccessControl.FileSecurity security = null;
            try
            {
                security = this.From.GetAccessControl();
            }
            catch
            {
            }

            if (this.QuickOperation())
                this.OSMoveRename(stats); // ask the OS to do it for us, since it's easy and quick!
            else
                this.CopyItOurself(ref pause, stats); // do it ourself!

            // set NTFS permissions
            try
            {
                if (security != null)
                    this.To.SetAccessControl(security);
            }
            catch
            {
            }

            if (!this.Error)
            {
                ActionCopyMoveRename.WriteMetaData(
                    this.To.FullName,
                    this.Episode,
                    settings.ArtworkPath);
            }

            return !this.Error;
        }

        #endregion

        #region Item Members

        public bool SameAs(Item o)
        {
            ActionCopyMoveRename cmr = o as ActionCopyMoveRename;

            return ((cmr != null) && (this.Operation == cmr.Operation) && Helpers.Same(this.From, cmr.From) && Helpers.Same(this.To, cmr.To));
        }

        public int Compare(Item o)
        {
            ActionCopyMoveRename cmr = o as ActionCopyMoveRename;

            if (cmr == null || this.From.Directory == null || this.To.Directory == null || cmr.From.Directory == null || cmr.To.Directory == null)
                return 0;

            string s1 = this.From.FullName + (this.From.Directory.Root.FullName != this.To.Directory.Root.FullName ? "0" : "1");
            string s2 = cmr.From.FullName + (cmr.From.Directory.Root.FullName != cmr.To.Directory.Root.FullName ? "0" : "1");

            return s1.CompareTo(s2);
        }

        #endregion

        #region ScanListItem Members

        public int IconNumber
        {
            get { return this.IsMoveRename() ? 4 : 3; }
        }

        public ProcessedEpisode Episode { get; set; }

        public IgnoreItem Ignore
        {
            get
            {
                if (this.To == null)
                    return null;
                return new IgnoreItem(this.To.FullName);
            }
        }

        public ListViewItem ScanListViewItem
        {
            get
            {
                ListViewItem lvi = new ListViewItem();

                if (this.Episode == null)
                {
                    lvi.Text = "";
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                }
                else
                {
                    lvi.Text = this.Episode.TheSeries.Name;
                    lvi.SubItems.Add(this.Episode.SeasonNumber.ToString());
                    lvi.SubItems.Add(this.Episode.NumsAsString());
                    DateTime? dt = this.Episode.GetAirDateDT(true);
                    if ((dt != null) && (dt.Value.CompareTo(DateTime.MaxValue) != 0))
                        lvi.SubItems.Add(dt.Value.ToShortDateString());
                    else
                        lvi.SubItems.Add("");
                }

                lvi.SubItems.Add(this.From.DirectoryName);
                lvi.SubItems.Add(this.From.Name);
                lvi.SubItems.Add(this.To.DirectoryName);
                lvi.SubItems.Add(this.To.Name);

                return lvi;
            }
        }

        public int ScanListViewGroup
        {
            get
            {
                if (this.Operation == Op.Rename)
                    return 1;
                if (this.Operation == Op.Copy)
                    return 2;
                if (this.Operation == Op.Move)
                    return 3;
                return 2;
            }
        }

        public string TargetFolder
        {
            get
            {
                if (this.To == null)
                    return null;
                return this.To.DirectoryName;
            }
        }

        #endregion

        private static string TempFor(FileInfo f)
        {
            return f.FullName + ".tvrenametemp";
        }

        private void NicelyStopAndCleanUp_Win32(Win32FileIO.WinFileIO copier)
        {
            copier.Close();
            string tempName = TempFor(this.To);
            if (System.IO.File.Exists(tempName))
                System.IO.File.Delete(tempName);
        }

        private void NicelyStopAndCleanUp_Streams(BinaryReader msr, BinaryWriter msw)
        {
            if (msw != null)
            {
                msw.Close();
                string tempName = TempFor(this.To);
                if (System.IO.File.Exists(tempName))
                    System.IO.File.Delete(tempName);
            }
            if (msr != null)
                msr.Close();
        }

        public bool QuickOperation()
        {
            if ((this.From == null) || (this.To == null) || (this.From.Directory == null) || (this.To.Directory == null))
                return false;

            return (this.IsMoveRename() && (this.From.Directory.Root.FullName.ToLower() == this.To.Directory.Root.FullName.ToLower())); // same device ... TODO: UNC paths?
        }

        private static void KeepTimestamps(FileInfo from, FileInfo to)
        {
            to.CreationTime = from.CreationTime;
            to.CreationTimeUtc = from.CreationTimeUtc;
            to.LastAccessTime = from.LastAccessTime;
            to.LastAccessTimeUtc = from.LastAccessTimeUtc;
            to.LastWriteTime = from.LastWriteTime;
            to.LastWriteTimeUtc = from.LastWriteTimeUtc;
        }

        private void OSMoveRename(TVRenameStats stats)
        {
            try
            {
                if (Helpers.Same(this.From, this.To))
                {
                    // XP won't actually do a rename if its only a case difference
                    string tempName = TempFor(this.To);
                    this.From.MoveTo(tempName);
                    System.IO.File.Move(tempName, this.To.FullName);
                }
                else
                    this.From.MoveTo(this.To.FullName);

                KeepTimestamps(this.From, this.To);

                this.Done = true;

                System.Diagnostics.Debug.Assert((this.Operation == ActionCopyMoveRename.Op.Move) || (this.Operation == ActionCopyMoveRename.Op.Rename));

                if (this.Operation == ActionCopyMoveRename.Op.Move)
                    stats.FilesMoved++;
                else if (this.Operation == ActionCopyMoveRename.Op.Rename)
                    stats.FilesRenamed++;
            }
            catch (System.Exception e)
            {
                this.Done = true;
                this.Error = true;
                this.ErrorText = e.Message;
            }
        }

        private void CopyItOurself(ref bool pause, TVRenameStats stats)
        {
            const int kArrayLength = 1 * 1024 * 1024;
            Byte[] dataArray = new Byte[kArrayLength];

            bool useWin32 = Version.OnWindows() && !Version.OnMono();

            Win32FileIO.WinFileIO copier = null;

            BinaryReader msr = null;
            BinaryWriter msw = null;

            try
            {
                long thisFileCopied = 0;
                long thisFileSize = this.SourceFileSize();

                string tempName = TempFor(this.To);
                if (System.IO.File.Exists(tempName))
                    System.IO.File.Delete(tempName);

                if (useWin32)
                {
                    copier = new Win32FileIO.WinFileIO(dataArray);
                    copier.OpenForReading(this.From.FullName);
                    copier.OpenForWriting(tempName);
                }
                else
                {
                    msr = new BinaryReader(new FileStream(this.From.FullName, FileMode.Open, FileAccess.Read));
                    msw = new BinaryWriter(new FileStream(tempName, FileMode.CreateNew));
                }

                for (; ; )
                {
                    int n = useWin32 ? copier.ReadBlocks(kArrayLength) : msr.Read(dataArray, 0, kArrayLength);
                    if (n == 0)
                        break;

                    if (useWin32)
                    {
                        copier.WriteBlocks(n);
                    }
                    else
                    {
                        msw.Write(dataArray, 0, n);
                    }
                    thisFileCopied += n;

                    double pct = (thisFileSize != 0) ? (100.0 * thisFileCopied / thisFileSize) : this.Done ? 100 : 0;
                    if (pct > 100.0)
                        pct = 100.0;
                    this.PercentDone = pct;

                    while (pause)
                        System.Threading.Thread.Sleep(100);
                }

                if (useWin32)
                {
                    copier.Close();
                }
                else
                {
                    msr.Close();
                    msw.Close();
                }

                // rename temp version to final name
                if (this.To.Exists)
                    this.To.Delete(); // outta ma way!
                System.IO.File.Move(tempName, this.To.FullName);

                KeepTimestamps(this.From, this.To);

                // if that was a move/rename, delete the source
                if (this.IsMoveRename())
                    this.From.Delete();

                if (this.Operation == ActionCopyMoveRename.Op.Move)
                    stats.FilesMoved++;
                else if (this.Operation == ActionCopyMoveRename.Op.Rename)
                    stats.FilesRenamed++;
                else if (this.Operation == ActionCopyMoveRename.Op.Copy)
                    stats.FilesCopied++;

                this.Done = true;
            } // try
            catch (System.Threading.ThreadAbortException)
            {
                if (useWin32)
                {
                    this.NicelyStopAndCleanUp_Win32(copier);
                }
                else
                {
                    this.NicelyStopAndCleanUp_Streams(msr, msw);
                }
                return;
            }
            catch (Exception ex)
            {
                // handle any exception type
                this.Error = true;
                this.Done = true;
                this.ErrorText = ex.Message;
                if (useWin32)
                {
                    this.NicelyStopAndCleanUp_Win32(copier);
                }
                else
                {
                    this.NicelyStopAndCleanUp_Streams(msr, msw);
                }
            }
        }

        private static void WriteMetaData(string episodePath, ProcessedEpisode episode, string artworkRootPath)
        {
            using (TagLib.File file = TagLib.File.Create(episodePath))
            {
                TagLib.Mpeg4.AppleTag customTag = (TagLib.Mpeg4.AppleTag)file.GetTag(TagLib.TagTypes.Apple, true);

                // Track Number? (Not sure what this is used for)
                customTag.Track = (uint)episode.EpNum2;

                // STIK || Media Type Tag
                customTag.ClearData("stik");
                var stikVector = new TagLib.ByteVector();
                stikVector.Add((byte)10);
                customTag.SetData("stik", stikVector, (int)TagLib.Mpeg4.AppleDataBox.FlagType.ContainsData);

                // Show Name
                customTag.ClearData("tvsh");
                customTag.SetText("tvsh", episode.SI.ShowName);

                // Season Number
                customTag.ClearData("tvsn");
                var seasonNumberVector = TagLib.ByteVector.FromInt(episode.SeasonNumber);
                customTag.SetData("tvsn", seasonNumberVector, (int)TagLib.Mpeg4.AppleDataBox.FlagType.ContainsData);

                // Episode Number
                customTag.ClearData("tves");
                var episodeNumberVector = TagLib.ByteVector.FromInt(episode.EpNum2);
                customTag.SetData("tves", episodeNumberVector, (int)TagLib.Mpeg4.AppleDataBox.FlagType.ContainsData);

                // Episode Name
                customTag.ClearData("tven");
                customTag.SetText("tven", episode.Name);

                // Description
                customTag.ClearData("ldes");
                customTag.SetText("ldes", episode.Overview);

                // Artwork
                if (!string.IsNullOrEmpty(artworkRootPath))
                {
                    var artwork = ActionCopyMoveRename.FindArtworkPath(artworkRootPath, episode.SI.ShowName, episode.SeasonNumber);
                    file.Tag.Pictures = artwork.Select(a => new TagLib.Picture(a)).ToArray();
                }

                file.Save();
            }
        }

        public static List<string> FindArtworkPath(string rootPath, string showName, int seasonNumber)
        {
            var possibleArtwork = new List<string>();
            possibleArtwork.AddRange(Directory.GetFiles(rootPath,
                showName + "-Season" + seasonNumber + ".*"));
            possibleArtwork.AddRange(Directory.GetFiles(rootPath,
                showName.Replace(" ", "") + "-Season" + seasonNumber + ".*"));
            possibleArtwork.AddRange(Directory.GetFiles(rootPath,
                showName + "?.*"));
            return possibleArtwork;
        }

        // --------------------------------------------------------------------------------------------------------

        public bool IsMoveRename() // same thing to the OS
        {
            return ((this.Operation == Op.Move) || (this.Operation == Op.Rename));
        }

        public bool SameSource(ActionCopyMoveRename o)
        {
            return (Helpers.Same(this.From, o.From));
        }

        // ========================================================================================================

        private long SourceFileSize()
        {
            try
            {
                return this.From.Length;
            }
            catch
            {
                return 1;
            }
        }
    }
}