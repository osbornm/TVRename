﻿//
// Main website for TVRename is http://tvrename.com
//
// Source code available at http://code.google.com/p/tvrename/
//
// This code is released under GPLv3 http://www.gnu.org/licenses/gpl.html
//


namespace TVRename
{
    partial class Preferences
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.OKButton = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.ReplacementsGrid = new SourceGrid.Grid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExportRSSDaysPast = new System.Windows.Forms.TextBox();
            this.bnBrowseWTWXML = new System.Windows.Forms.Button();
            this.txtWTWXML = new System.Windows.Forms.TextBox();
            this.cbWTWXML = new System.Windows.Forms.CheckBox();
            this.bnBrowseWTWRSS = new System.Windows.Forms.Button();
            this.txtWTWRSS = new System.Windows.Forms.TextBox();
            this.cbWTWRSS = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtExportRSSMaxDays = new System.Windows.Forms.TextBox();
            this.txtExportRSSMaxShows = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.cbTxtToSub = new System.Windows.Forms.CheckBox();
            this.txtSpecialsFolderName = new System.Windows.Forms.TextBox();
            this.txtVideoExtensions = new System.Windows.Forms.TextBox();
            this.cbStartupTab = new System.Windows.Forms.ComboBox();
            this.cbShowEpisodePictures = new System.Windows.Forms.CheckBox();
            this.cbLeadingZero = new System.Windows.Forms.CheckBox();
            this.cbKeepTogether = new System.Windows.Forms.CheckBox();
            this.chkShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.cbNotificationIcon = new System.Windows.Forms.CheckBox();
            this.txtWTWDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbGeneral = new System.Windows.Forms.TabPage();
            this.rbWTWScan = new System.Windows.Forms.RadioButton();
            this.rbWTWSearch = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLookForAirdate = new System.Windows.Forms.CheckBox();
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbAutoSelInMyShows = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtParallelDownloads = new System.Windows.Forms.TextBox();
            this.tbFilesAndFolders = new System.Windows.Forms.TabPage();
            this.bnReplaceRemove = new System.Windows.Forms.Button();
            this.bnReplaceAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMaxSampleSize = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOtherExtensions = new System.Windows.Forms.TextBox();
            this.cbForceLower = new System.Windows.Forms.CheckBox();
            this.cbIgnoreSamples = new System.Windows.Forms.CheckBox();
            this.tbAutoExport = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bnBrowseFOXML = new System.Windows.Forms.Button();
            this.cbFOXML = new System.Windows.Forms.CheckBox();
            this.txtFOXML = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bnBrowseRenamingXML = new System.Windows.Forms.Button();
            this.cbRenamingXML = new System.Windows.Forms.CheckBox();
            this.txtRenamingXML = new System.Windows.Forms.TextBox();
            this.bnBrowseMissingCSV = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bnBrowseMissingXML = new System.Windows.Forms.Button();
            this.cbMissingXML = new System.Windows.Forms.CheckBox();
            this.txtMissingXML = new System.Windows.Forms.TextBox();
            this.txtMissingCSV = new System.Windows.Forms.TextBox();
            this.cbMissingCSV = new System.Windows.Forms.CheckBox();
            this.tpScanOptions = new System.Windows.Forms.TabPage();
            this.cbMetaSubfolder = new System.Windows.Forms.CheckBox();
            this.cbMeta = new System.Windows.Forms.CheckBox();
            this.rbFolderFanArt = new System.Windows.Forms.RadioButton();
            this.rbFolderPoster = new System.Windows.Forms.RadioButton();
            this.rbFolderBanner = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.cbSearchRSS = new System.Windows.Forms.CheckBox();
            this.cbEpImgs = new System.Windows.Forms.CheckBox();
            this.cbNFOs = new System.Windows.Forms.CheckBox();
            this.cbFolderJpg = new System.Windows.Forms.CheckBox();
            this.cbRenameCheck = new System.Windows.Forms.CheckBox();
            this.cbMissing = new System.Windows.Forms.CheckBox();
            this.cbLeaveOriginals = new System.Windows.Forms.CheckBox();
            this.cbCheckSABnzbd = new System.Windows.Forms.CheckBox();
            this.cbCheckuTorrent = new System.Windows.Forms.CheckBox();
            this.cbSearchLocally = new System.Windows.Forms.CheckBox();
            this.tbSearchFolders = new System.Windows.Forms.TabPage();
            this.cbMonitorFolder = new System.Windows.Forms.CheckBox();
            this.bnOpenSearchFolder = new System.Windows.Forms.Button();
            this.bnRemoveSearchFolder = new System.Windows.Forms.Button();
            this.bnAddSearchFolder = new System.Windows.Forms.Button();
            this.lbSearchFolders = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbuTorrentNZB = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSABHostPort = new System.Windows.Forms.TextBox();
            this.txtSABAPIKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bnUTBrowseResumeDat = new System.Windows.Forms.Button();
            this.txtUTResumeDatPath = new System.Windows.Forms.TextBox();
            this.bnRSSBrowseuTorrent = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRSSuTorrentPath = new System.Windows.Forms.TextBox();
            this.RSSGrid = new SourceGrid.Grid();
            this.bnRSSRemove = new System.Windows.Forms.Button();
            this.bnRSSAdd = new System.Windows.Forms.Button();
            this.bnRSSGo = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tpTreeColoring = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cboShowStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShowStatusColor = new System.Windows.Forms.TextBox();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.bnRemoveDefinedColor = new System.Windows.Forms.Button();
            this.btnAddShowStatusColoring = new System.Windows.Forms.Button();
            this.lvwDefinedColors = new System.Windows.Forms.ListView();
            this.colShowStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.txtArtworkPath = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbGeneral.SuspendLayout();
            this.tbFilesAndFolders.SuspendLayout();
            this.tbAutoExport.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpScanOptions.SuspendLayout();
            this.tbSearchFolders.SuspendLayout();
            this.tbuTorrentNZB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpTreeColoring.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(560, 902);
            this.OKButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(150, 44);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Location = new System.Drawing.Point(722, 902);
            this.bnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(150, 44);
            this.bnCancel.TabIndex = 1;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ReplacementsGrid
            // 
            this.ReplacementsGrid.BackColor = System.Drawing.SystemColors.Window;
            this.ReplacementsGrid.EnableSort = true;
            this.ReplacementsGrid.Location = new System.Drawing.Point(12, 37);
            this.ReplacementsGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ReplacementsGrid.Name = "ReplacementsGrid";
            this.ReplacementsGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.ReplacementsGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.ReplacementsGrid.Size = new System.Drawing.Size(806, 238);
            this.ReplacementsGrid.TabIndex = 1;
            this.ReplacementsGrid.TabStop = true;
            this.ReplacementsGrid.ToolTipText = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtExportRSSDaysPast);
            this.groupBox2.Controls.Add(this.bnBrowseWTWXML);
            this.groupBox2.Controls.Add(this.txtWTWXML);
            this.groupBox2.Controls.Add(this.cbWTWXML);
            this.groupBox2.Controls.Add(this.bnBrowseWTWRSS);
            this.groupBox2.Controls.Add(this.txtWTWRSS);
            this.groupBox2.Controls.Add(this.cbWTWRSS);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtExportRSSMaxDays);
            this.groupBox2.Controls.Add(this.txtExportRSSMaxShows);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(806, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "When to Watch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "in the past.";
            // 
            // txtExportRSSDaysPast
            // 
            this.txtExportRSSDaysPast.Location = new System.Drawing.Point(588, 154);
            this.txtExportRSSDaysPast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtExportRSSDaysPast.Name = "txtExportRSSDaysPast";
            this.txtExportRSSDaysPast.Size = new System.Drawing.Size(52, 31);
            this.txtExportRSSDaysPast.TabIndex = 20;
            // 
            // bnBrowseWTWXML
            // 
            this.bnBrowseWTWXML.Location = new System.Drawing.Point(644, 90);
            this.bnBrowseWTWXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnBrowseWTWXML.Name = "bnBrowseWTWXML";
            this.bnBrowseWTWXML.Size = new System.Drawing.Size(150, 44);
            this.bnBrowseWTWXML.TabIndex = 19;
            this.bnBrowseWTWXML.Text = "Browse...";
            this.bnBrowseWTWXML.UseVisualStyleBackColor = true;
            this.bnBrowseWTWXML.Click += new System.EventHandler(this.bnBrowseWTWXML_Click);
            // 
            // txtWTWXML
            // 
            this.txtWTWXML.Location = new System.Drawing.Point(130, 94);
            this.txtWTWXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWTWXML.Name = "txtWTWXML";
            this.txtWTWXML.Size = new System.Drawing.Size(498, 31);
            this.txtWTWXML.TabIndex = 18;
            // 
            // cbWTWXML
            // 
            this.cbWTWXML.AutoSize = true;
            this.cbWTWXML.Location = new System.Drawing.Point(20, 98);
            this.cbWTWXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbWTWXML.Name = "cbWTWXML";
            this.cbWTWXML.Size = new System.Drawing.Size(88, 29);
            this.cbWTWXML.TabIndex = 17;
            this.cbWTWXML.Text = "XML";
            this.cbWTWXML.UseVisualStyleBackColor = true;
            this.cbWTWXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // bnBrowseWTWRSS
            // 
            this.bnBrowseWTWRSS.Location = new System.Drawing.Point(642, 35);
            this.bnBrowseWTWRSS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnBrowseWTWRSS.Name = "bnBrowseWTWRSS";
            this.bnBrowseWTWRSS.Size = new System.Drawing.Size(150, 44);
            this.bnBrowseWTWRSS.TabIndex = 2;
            this.bnBrowseWTWRSS.Text = "Browse...";
            this.bnBrowseWTWRSS.UseVisualStyleBackColor = true;
            this.bnBrowseWTWRSS.Click += new System.EventHandler(this.bnBrowseWTWRSS_Click);
            // 
            // txtWTWRSS
            // 
            this.txtWTWRSS.Location = new System.Drawing.Point(128, 38);
            this.txtWTWRSS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWTWRSS.Name = "txtWTWRSS";
            this.txtWTWRSS.Size = new System.Drawing.Size(498, 31);
            this.txtWTWRSS.TabIndex = 1;
            // 
            // cbWTWRSS
            // 
            this.cbWTWRSS.AutoSize = true;
            this.cbWTWRSS.Location = new System.Drawing.Point(20, 42);
            this.cbWTWRSS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbWTWRSS.Name = "cbWTWRSS";
            this.cbWTWRSS.Size = new System.Drawing.Size(87, 29);
            this.cbWTWRSS.TabIndex = 0;
            this.cbWTWRSS.Text = "RSS";
            this.cbWTWRSS.UseVisualStyleBackColor = true;
            this.cbWTWRSS.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(424, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 25);
            this.label17.TabIndex = 7;
            this.label17.Text = "days worth and";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 160);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 25);
            this.label16.TabIndex = 5;
            this.label16.Text = "shows, or";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 160);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "No more than";
            // 
            // txtExportRSSMaxDays
            // 
            this.txtExportRSSMaxDays.Location = new System.Drawing.Point(356, 154);
            this.txtExportRSSMaxDays.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtExportRSSMaxDays.Name = "txtExportRSSMaxDays";
            this.txtExportRSSMaxDays.Size = new System.Drawing.Size(52, 31);
            this.txtExportRSSMaxDays.TabIndex = 6;
            this.txtExportRSSMaxDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOnlyKeyPress);
            // 
            // txtExportRSSMaxShows
            // 
            this.txtExportRSSMaxShows.Location = new System.Drawing.Point(172, 154);
            this.txtExportRSSMaxShows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtExportRSSMaxShows.Name = "txtExportRSSMaxShows";
            this.txtExportRSSMaxShows.Size = new System.Drawing.Size(52, 31);
            this.txtExportRSSMaxShows.TabIndex = 4;
            this.txtExportRSSMaxShows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOnlyKeyPress);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "xml";
            this.saveFile.Filter = "RSS files (*.rss)|*.rss|XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // cbTxtToSub
            // 
            this.cbTxtToSub.AutoSize = true;
            this.cbTxtToSub.Location = new System.Drawing.Point(12, 498);
            this.cbTxtToSub.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbTxtToSub.Name = "cbTxtToSub";
            this.cbTxtToSub.Size = new System.Drawing.Size(230, 29);
            this.cbTxtToSub.TabIndex = 9;
            this.cbTxtToSub.Text = "&Rename .txt to .sub";
            this.cbTxtToSub.UseVisualStyleBackColor = true;
            // 
            // txtSpecialsFolderName
            // 
            this.txtSpecialsFolderName.Location = new System.Drawing.Point(226, 588);
            this.txtSpecialsFolderName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSpecialsFolderName.Name = "txtSpecialsFolderName";
            this.txtSpecialsFolderName.Size = new System.Drawing.Size(554, 31);
            this.txtSpecialsFolderName.TabIndex = 12;
            // 
            // txtVideoExtensions
            // 
            this.txtVideoExtensions.Location = new System.Drawing.Point(198, 358);
            this.txtVideoExtensions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtVideoExtensions.Name = "txtVideoExtensions";
            this.txtVideoExtensions.Size = new System.Drawing.Size(582, 31);
            this.txtVideoExtensions.TabIndex = 5;
            // 
            // cbStartupTab
            // 
            this.cbStartupTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartupTab.FormattingEnabled = true;
            this.cbStartupTab.Items.AddRange(new object[] {
            "My Shows",
            "Scan",
            "When to Watch"});
            this.cbStartupTab.Location = new System.Drawing.Point(148, 169);
            this.cbStartupTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbStartupTab.Name = "cbStartupTab";
            this.cbStartupTab.Size = new System.Drawing.Size(266, 33);
            this.cbStartupTab.TabIndex = 7;
            // 
            // cbShowEpisodePictures
            // 
            this.cbShowEpisodePictures.AutoSize = true;
            this.cbShowEpisodePictures.Location = new System.Drawing.Point(18, 265);
            this.cbShowEpisodePictures.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbShowEpisodePictures.Name = "cbShowEpisodePictures";
            this.cbShowEpisodePictures.Size = new System.Drawing.Size(436, 29);
            this.cbShowEpisodePictures.TabIndex = 10;
            this.cbShowEpisodePictures.Text = "S&how episode pictures in episode guides";
            this.cbShowEpisodePictures.UseVisualStyleBackColor = true;
            // 
            // cbLeadingZero
            // 
            this.cbLeadingZero.AutoSize = true;
            this.cbLeadingZero.Location = new System.Drawing.Point(12, 542);
            this.cbLeadingZero.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbLeadingZero.Name = "cbLeadingZero";
            this.cbLeadingZero.Size = new System.Drawing.Size(337, 29);
            this.cbLeadingZero.TabIndex = 10;
            this.cbLeadingZero.Text = "&Leading 0 on Season numbers";
            this.cbLeadingZero.UseVisualStyleBackColor = true;
            // 
            // cbKeepTogether
            // 
            this.cbKeepTogether.AutoSize = true;
            this.cbKeepTogether.Location = new System.Drawing.Point(12, 458);
            this.cbKeepTogether.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbKeepTogether.Name = "cbKeepTogether";
            this.cbKeepTogether.Size = new System.Drawing.Size(499, 29);
            this.cbKeepTogether.TabIndex = 8;
            this.cbKeepTogether.Text = "&Copy/Move files with same base name as video";
            this.cbKeepTogether.UseVisualStyleBackColor = true;
            this.cbKeepTogether.CheckedChanged += new System.EventHandler(this.cbKeepTogether_CheckedChanged);
            // 
            // chkShowInTaskbar
            // 
            this.chkShowInTaskbar.AutoSize = true;
            this.chkShowInTaskbar.Location = new System.Drawing.Point(338, 221);
            this.chkShowInTaskbar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkShowInTaskbar.Name = "chkShowInTaskbar";
            this.chkShowInTaskbar.Size = new System.Drawing.Size(197, 29);
            this.chkShowInTaskbar.TabIndex = 9;
            this.chkShowInTaskbar.Text = "Show in &taskbar";
            this.chkShowInTaskbar.UseVisualStyleBackColor = true;
            this.chkShowInTaskbar.CheckedChanged += new System.EventHandler(this.chkShowInTaskbar_CheckedChanged);
            // 
            // cbNotificationIcon
            // 
            this.cbNotificationIcon.AutoSize = true;
            this.cbNotificationIcon.Location = new System.Drawing.Point(18, 221);
            this.cbNotificationIcon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbNotificationIcon.Name = "cbNotificationIcon";
            this.cbNotificationIcon.Size = new System.Drawing.Size(302, 29);
            this.cbNotificationIcon.TabIndex = 8;
            this.cbNotificationIcon.Text = "Show &notification area icon";
            this.cbNotificationIcon.UseVisualStyleBackColor = true;
            this.cbNotificationIcon.CheckedChanged += new System.EventHandler(this.cbNotificationIcon_CheckedChanged);
            // 
            // txtWTWDays
            // 
            this.txtWTWDays.Location = new System.Drawing.Point(184, 17);
            this.txtWTWDays.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWTWDays.Name = "txtWTWDays";
            this.txtWTWDays.Size = new System.Drawing.Size(52, 31);
            this.txtWTWDays.TabIndex = 1;
            this.txtWTWDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOnlyKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "days counts as recent";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 594);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "&Specials folder name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 363);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "&Video extensions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Startup tab:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "&When to watch";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbGeneral);
            this.tabControl1.Controls.Add(this.tbFilesAndFolders);
            this.tabControl1.Controls.Add(this.tbAutoExport);
            this.tabControl1.Controls.Add(this.tpScanOptions);
            this.tabControl1.Controls.Add(this.tbSearchFolders);
            this.tabControl1.Controls.Add(this.tbuTorrentNZB);
            this.tabControl1.Controls.Add(this.tpTreeColoring);
            this.tabControl1.Location = new System.Drawing.Point(24, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 856);
            this.tabControl1.TabIndex = 5;
            // 
            // tbGeneral
            // 
            this.tbGeneral.Controls.Add(this.txtArtworkPath);
            this.tbGeneral.Controls.Add(this.label12);
            this.tbGeneral.Controls.Add(this.rbWTWScan);
            this.tbGeneral.Controls.Add(this.rbWTWSearch);
            this.tbGeneral.Controls.Add(this.label10);
            this.tbGeneral.Controls.Add(this.cbLookForAirdate);
            this.tbGeneral.Controls.Add(this.cbLanguages);
            this.tbGeneral.Controls.Add(this.cbStartupTab);
            this.tbGeneral.Controls.Add(this.label21);
            this.tbGeneral.Controls.Add(this.label1);
            this.tbGeneral.Controls.Add(this.cbAutoSelInMyShows);
            this.tbGeneral.Controls.Add(this.cbShowEpisodePictures);
            this.tbGeneral.Controls.Add(this.label11);
            this.tbGeneral.Controls.Add(this.label6);
            this.tbGeneral.Controls.Add(this.chkShowInTaskbar);
            this.tbGeneral.Controls.Add(this.label20);
            this.tbGeneral.Controls.Add(this.label2);
            this.tbGeneral.Controls.Add(this.cbNotificationIcon);
            this.tbGeneral.Controls.Add(this.txtParallelDownloads);
            this.tbGeneral.Controls.Add(this.txtWTWDays);
            this.tbGeneral.Location = new System.Drawing.Point(4, 64);
            this.tbGeneral.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbGeneral.Name = "tbGeneral";
            this.tbGeneral.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbGeneral.Size = new System.Drawing.Size(840, 788);
            this.tbGeneral.TabIndex = 0;
            this.tbGeneral.Text = "General";
            this.tbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbWTWScan
            // 
            this.rbWTWScan.AutoSize = true;
            this.rbWTWScan.Location = new System.Drawing.Point(54, 129);
            this.rbWTWScan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbWTWScan.Name = "rbWTWScan";
            this.rbWTWScan.Size = new System.Drawing.Size(92, 29);
            this.rbWTWScan.TabIndex = 5;
            this.rbWTWScan.TabStop = true;
            this.rbWTWScan.Text = "S&can";
            this.rbWTWScan.UseVisualStyleBackColor = true;
            // 
            // rbWTWSearch
            // 
            this.rbWTWSearch.AutoSize = true;
            this.rbWTWSearch.Location = new System.Drawing.Point(54, 92);
            this.rbWTWSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbWTWSearch.Name = "rbWTWSearch";
            this.rbWTWSearch.Size = new System.Drawing.Size(111, 29);
            this.rbWTWSearch.TabIndex = 4;
            this.rbWTWSearch.TabStop = true;
            this.rbWTWSearch.Text = "S&earch";
            this.rbWTWSearch.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "&Preferred language:";
            // 
            // cbLookForAirdate
            // 
            this.cbLookForAirdate.AutoSize = true;
            this.cbLookForAirdate.Location = new System.Drawing.Point(18, 404);
            this.cbLookForAirdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbLookForAirdate.Name = "cbLookForAirdate";
            this.cbLookForAirdate.Size = new System.Drawing.Size(315, 29);
            this.cbLookForAirdate.TabIndex = 15;
            this.cbLookForAirdate.Text = "&Look for airdate in filenames";
            this.cbLookForAirdate.UseVisualStyleBackColor = true;
            // 
            // cbLanguages
            // 
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Items.AddRange(new object[] {
            "My Shows",
            "Scan",
            "When to Watch"});
            this.cbLanguages.Location = new System.Drawing.Point(224, 444);
            this.cbLanguages.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(288, 33);
            this.cbLanguages.Sorted = true;
            this.cbLanguages.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 315);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 25);
            this.label21.TabIndex = 11;
            this.label21.Text = "&Download up to";
            // 
            // cbAutoSelInMyShows
            // 
            this.cbAutoSelInMyShows.AutoSize = true;
            this.cbAutoSelInMyShows.Location = new System.Drawing.Point(18, 360);
            this.cbAutoSelInMyShows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbAutoSelInMyShows.Name = "cbAutoSelInMyShows";
            this.cbAutoSelInMyShows.Size = new System.Drawing.Size(537, 29);
            this.cbAutoSelInMyShows.TabIndex = 14;
            this.cbAutoSelInMyShows.Text = "&Automatically select show and season in My Shows";
            this.cbAutoSelInMyShows.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(365, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Double-click in When to Watch does:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(252, 315);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(347, 25);
            this.label20.TabIndex = 13;
            this.label20.Text = "shows simultaneously from thetvdb";
            // 
            // txtParallelDownloads
            // 
            this.txtParallelDownloads.Location = new System.Drawing.Point(184, 310);
            this.txtParallelDownloads.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtParallelDownloads.Name = "txtParallelDownloads";
            this.txtParallelDownloads.Size = new System.Drawing.Size(52, 31);
            this.txtParallelDownloads.TabIndex = 12;
            this.txtParallelDownloads.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOnlyKeyPress);
            // 
            // tbFilesAndFolders
            // 
            this.tbFilesAndFolders.Controls.Add(this.bnReplaceRemove);
            this.tbFilesAndFolders.Controls.Add(this.bnReplaceAdd);
            this.tbFilesAndFolders.Controls.Add(this.label3);
            this.tbFilesAndFolders.Controls.Add(this.ReplacementsGrid);
            this.tbFilesAndFolders.Controls.Add(this.label19);
            this.tbFilesAndFolders.Controls.Add(this.txtMaxSampleSize);
            this.tbFilesAndFolders.Controls.Add(this.cbTxtToSub);
            this.tbFilesAndFolders.Controls.Add(this.label22);
            this.tbFilesAndFolders.Controls.Add(this.label14);
            this.tbFilesAndFolders.Controls.Add(this.txtSpecialsFolderName);
            this.tbFilesAndFolders.Controls.Add(this.label13);
            this.tbFilesAndFolders.Controls.Add(this.txtOtherExtensions);
            this.tbFilesAndFolders.Controls.Add(this.txtVideoExtensions);
            this.tbFilesAndFolders.Controls.Add(this.cbKeepTogether);
            this.tbFilesAndFolders.Controls.Add(this.cbForceLower);
            this.tbFilesAndFolders.Controls.Add(this.cbIgnoreSamples);
            this.tbFilesAndFolders.Controls.Add(this.cbLeadingZero);
            this.tbFilesAndFolders.Location = new System.Drawing.Point(4, 124);
            this.tbFilesAndFolders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbFilesAndFolders.Name = "tbFilesAndFolders";
            this.tbFilesAndFolders.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbFilesAndFolders.Size = new System.Drawing.Size(840, 728);
            this.tbFilesAndFolders.TabIndex = 1;
            this.tbFilesAndFolders.Text = "Files and Folders";
            this.tbFilesAndFolders.UseVisualStyleBackColor = true;
            // 
            // bnReplaceRemove
            // 
            this.bnReplaceRemove.Location = new System.Drawing.Point(180, 287);
            this.bnReplaceRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnReplaceRemove.Name = "bnReplaceRemove";
            this.bnReplaceRemove.Size = new System.Drawing.Size(150, 44);
            this.bnReplaceRemove.TabIndex = 3;
            this.bnReplaceRemove.Text = "&Remove";
            this.bnReplaceRemove.UseVisualStyleBackColor = true;
            this.bnReplaceRemove.Click += new System.EventHandler(this.bnReplaceRemove_Click);
            // 
            // bnReplaceAdd
            // 
            this.bnReplaceAdd.Location = new System.Drawing.Point(18, 287);
            this.bnReplaceAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnReplaceAdd.Name = "bnReplaceAdd";
            this.bnReplaceAdd.Size = new System.Drawing.Size(150, 44);
            this.bnReplaceAdd.TabIndex = 2;
            this.bnReplaceAdd.Text = "&Add";
            this.bnReplaceAdd.UseVisualStyleBackColor = true;
            this.bnReplaceAdd.Click += new System.EventHandler(this.bnReplaceAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filename Replacements";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(456, 644);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 25);
            this.label19.TabIndex = 15;
            this.label19.Text = "MB in size";
            // 
            // txtMaxSampleSize
            // 
            this.txtMaxSampleSize.Location = new System.Drawing.Point(344, 638);
            this.txtMaxSampleSize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaxSampleSize.Name = "txtMaxSampleSize";
            this.txtMaxSampleSize.Size = new System.Drawing.Size(102, 31);
            this.txtMaxSampleSize.TabIndex = 14;
            this.txtMaxSampleSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOnlyKeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 413);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(181, 25);
            this.label22.TabIndex = 6;
            this.label22.Text = "&Other extensions:";
            // 
            // txtOtherExtensions
            // 
            this.txtOtherExtensions.Location = new System.Drawing.Point(198, 408);
            this.txtOtherExtensions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOtherExtensions.Name = "txtOtherExtensions";
            this.txtOtherExtensions.Size = new System.Drawing.Size(582, 31);
            this.txtOtherExtensions.TabIndex = 7;
            // 
            // cbForceLower
            // 
            this.cbForceLower.AutoSize = true;
            this.cbForceLower.Location = new System.Drawing.Point(12, 687);
            this.cbForceLower.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbForceLower.Name = "cbForceLower";
            this.cbForceLower.Size = new System.Drawing.Size(332, 29);
            this.cbForceLower.TabIndex = 16;
            this.cbForceLower.Text = "&Make all filenames lower case";
            this.cbForceLower.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreSamples
            // 
            this.cbIgnoreSamples.AutoSize = true;
            this.cbIgnoreSamples.Location = new System.Drawing.Point(12, 642);
            this.cbIgnoreSamples.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbIgnoreSamples.Name = "cbIgnoreSamples";
            this.cbIgnoreSamples.Size = new System.Drawing.Size(322, 29);
            this.cbIgnoreSamples.TabIndex = 13;
            this.cbIgnoreSamples.Text = "&Ignore \"sample\" videos, up to";
            this.cbIgnoreSamples.UseVisualStyleBackColor = true;
            // 
            // tbAutoExport
            // 
            this.tbAutoExport.Controls.Add(this.groupBox5);
            this.tbAutoExport.Controls.Add(this.groupBox4);
            this.tbAutoExport.Controls.Add(this.bnBrowseMissingCSV);
            this.tbAutoExport.Controls.Add(this.groupBox3);
            this.tbAutoExport.Controls.Add(this.groupBox2);
            this.tbAutoExport.Controls.Add(this.txtMissingCSV);
            this.tbAutoExport.Controls.Add(this.cbMissingCSV);
            this.tbAutoExport.Location = new System.Drawing.Point(4, 124);
            this.tbAutoExport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbAutoExport.Name = "tbAutoExport";
            this.tbAutoExport.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbAutoExport.Size = new System.Drawing.Size(840, 728);
            this.tbAutoExport.TabIndex = 2;
            this.tbAutoExport.Text = "Automatic Export";
            this.tbAutoExport.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bnBrowseFOXML);
            this.groupBox5.Controls.Add(this.cbFOXML);
            this.groupBox5.Controls.Add(this.txtFOXML);
            this.groupBox5.Location = new System.Drawing.Point(12, 602);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox5.Size = new System.Drawing.Size(804, 106);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Finding and Organising";
            this.groupBox5.Visible = false;
            // 
            // bnBrowseFOXML
            // 
            this.bnBrowseFOXML.Location = new System.Drawing.Point(642, 37);
            this.bnBrowseFOXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnBrowseFOXML.Name = "bnBrowseFOXML";
            this.bnBrowseFOXML.Size = new System.Drawing.Size(150, 44);
            this.bnBrowseFOXML.TabIndex = 2;
            this.bnBrowseFOXML.Text = "Browse...";
            this.bnBrowseFOXML.UseVisualStyleBackColor = true;
            this.bnBrowseFOXML.Click += new System.EventHandler(this.bnBrowseFOXML_Click);
            // 
            // cbFOXML
            // 
            this.cbFOXML.AutoSize = true;
            this.cbFOXML.Location = new System.Drawing.Point(20, 44);
            this.cbFOXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbFOXML.Name = "cbFOXML";
            this.cbFOXML.Size = new System.Drawing.Size(88, 29);
            this.cbFOXML.TabIndex = 0;
            this.cbFOXML.Text = "XML";
            this.cbFOXML.UseVisualStyleBackColor = true;
            this.cbFOXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtFOXML
            // 
            this.txtFOXML.Location = new System.Drawing.Point(128, 40);
            this.txtFOXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFOXML.Name = "txtFOXML";
            this.txtFOXML.Size = new System.Drawing.Size(498, 31);
            this.txtFOXML.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bnBrowseRenamingXML);
            this.groupBox4.Controls.Add(this.cbRenamingXML);
            this.groupBox4.Controls.Add(this.txtRenamingXML);
            this.groupBox4.Location = new System.Drawing.Point(12, 481);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(804, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Renaming";
            this.groupBox4.Visible = false;
            // 
            // bnBrowseRenamingXML
            // 
            this.bnBrowseRenamingXML.Location = new System.Drawing.Point(642, 37);
            this.bnBrowseRenamingXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnBrowseRenamingXML.Name = "bnBrowseRenamingXML";
            this.bnBrowseRenamingXML.Size = new System.Drawing.Size(150, 44);
            this.bnBrowseRenamingXML.TabIndex = 2;
            this.bnBrowseRenamingXML.Text = "Browse...";
            this.bnBrowseRenamingXML.UseVisualStyleBackColor = true;
            this.bnBrowseRenamingXML.Click += new System.EventHandler(this.bnBrowseRenamingXML_Click);
            // 
            // cbRenamingXML
            // 
            this.cbRenamingXML.AutoSize = true;
            this.cbRenamingXML.Location = new System.Drawing.Point(20, 44);
            this.cbRenamingXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbRenamingXML.Name = "cbRenamingXML";
            this.cbRenamingXML.Size = new System.Drawing.Size(88, 29);
            this.cbRenamingXML.TabIndex = 0;
            this.cbRenamingXML.Text = "XML";
            this.cbRenamingXML.UseVisualStyleBackColor = true;
            this.cbRenamingXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtRenamingXML
            // 
            this.txtRenamingXML.Location = new System.Drawing.Point(128, 40);
            this.txtRenamingXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRenamingXML.Name = "txtRenamingXML";
            this.txtRenamingXML.Size = new System.Drawing.Size(498, 31);
            this.txtRenamingXML.TabIndex = 1;
            // 
            // bnBrowseMissingCSV
            // 
            this.bnBrowseMissingCSV.Location = new System.Drawing.Point(654, 435);
            this.bnBrowseMissingCSV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnBrowseMissingCSV.Name = "bnBrowseMissingCSV";
            this.bnBrowseMissingCSV.Size = new System.Drawing.Size(150, 44);
            this.bnBrowseMissingCSV.TabIndex = 2;
            this.bnBrowseMissingCSV.Text = "Browse...";
            this.bnBrowseMissingCSV.UseVisualStyleBackColor = true;
            this.bnBrowseMissingCSV.Visible = false;
            this.bnBrowseMissingCSV.Click += new System.EventHandler(this.bnBrowseMissingCSV_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bnBrowseMissingXML);
            this.groupBox3.Controls.Add(this.cbMissingXML);
            this.groupBox3.Controls.Add(this.txtMissingXML);
            this.groupBox3.Location = new System.Drawing.Point(12, 237);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(804, 106);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Missing";
            // 
            // bnBrowseMissingXML
            // 
            this.bnBrowseMissingXML.Location = new System.Drawing.Point(642, 37);
            this.bnBrowseMissingXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnBrowseMissingXML.Name = "bnBrowseMissingXML";
            this.bnBrowseMissingXML.Size = new System.Drawing.Size(150, 44);
            this.bnBrowseMissingXML.TabIndex = 5;
            this.bnBrowseMissingXML.Text = "Browse...";
            this.bnBrowseMissingXML.UseVisualStyleBackColor = true;
            this.bnBrowseMissingXML.Click += new System.EventHandler(this.bnBrowseMissingXML_Click);
            // 
            // cbMissingXML
            // 
            this.cbMissingXML.AutoSize = true;
            this.cbMissingXML.Location = new System.Drawing.Point(20, 44);
            this.cbMissingXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMissingXML.Name = "cbMissingXML";
            this.cbMissingXML.Size = new System.Drawing.Size(88, 29);
            this.cbMissingXML.TabIndex = 3;
            this.cbMissingXML.Text = "XML";
            this.cbMissingXML.UseVisualStyleBackColor = true;
            this.cbMissingXML.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // txtMissingXML
            // 
            this.txtMissingXML.Location = new System.Drawing.Point(128, 40);
            this.txtMissingXML.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMissingXML.Name = "txtMissingXML";
            this.txtMissingXML.Size = new System.Drawing.Size(498, 31);
            this.txtMissingXML.TabIndex = 4;
            // 
            // txtMissingCSV
            // 
            this.txtMissingCSV.Location = new System.Drawing.Point(140, 440);
            this.txtMissingCSV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMissingCSV.Name = "txtMissingCSV";
            this.txtMissingCSV.Size = new System.Drawing.Size(498, 31);
            this.txtMissingCSV.TabIndex = 1;
            this.txtMissingCSV.Visible = false;
            // 
            // cbMissingCSV
            // 
            this.cbMissingCSV.AutoSize = true;
            this.cbMissingCSV.Location = new System.Drawing.Point(32, 444);
            this.cbMissingCSV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMissingCSV.Name = "cbMissingCSV";
            this.cbMissingCSV.Size = new System.Drawing.Size(87, 29);
            this.cbMissingCSV.TabIndex = 0;
            this.cbMissingCSV.Text = "CSV";
            this.cbMissingCSV.UseVisualStyleBackColor = true;
            this.cbMissingCSV.Visible = false;
            this.cbMissingCSV.CheckedChanged += new System.EventHandler(this.EnableDisable);
            // 
            // tpScanOptions
            // 
            this.tpScanOptions.Controls.Add(this.cbMetaSubfolder);
            this.tpScanOptions.Controls.Add(this.cbMeta);
            this.tpScanOptions.Controls.Add(this.rbFolderFanArt);
            this.tpScanOptions.Controls.Add(this.rbFolderPoster);
            this.tpScanOptions.Controls.Add(this.rbFolderBanner);
            this.tpScanOptions.Controls.Add(this.label28);
            this.tpScanOptions.Controls.Add(this.cbSearchRSS);
            this.tpScanOptions.Controls.Add(this.cbEpImgs);
            this.tpScanOptions.Controls.Add(this.cbNFOs);
            this.tpScanOptions.Controls.Add(this.cbFolderJpg);
            this.tpScanOptions.Controls.Add(this.cbRenameCheck);
            this.tpScanOptions.Controls.Add(this.cbMissing);
            this.tpScanOptions.Controls.Add(this.cbLeaveOriginals);
            this.tpScanOptions.Controls.Add(this.cbCheckSABnzbd);
            this.tpScanOptions.Controls.Add(this.cbCheckuTorrent);
            this.tpScanOptions.Controls.Add(this.cbSearchLocally);
            this.tpScanOptions.Location = new System.Drawing.Point(4, 124);
            this.tpScanOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpScanOptions.Name = "tpScanOptions";
            this.tpScanOptions.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpScanOptions.Size = new System.Drawing.Size(840, 728);
            this.tpScanOptions.TabIndex = 6;
            this.tpScanOptions.Text = "Scan Options";
            this.tpScanOptions.UseVisualStyleBackColor = true;
            // 
            // cbMetaSubfolder
            // 
            this.cbMetaSubfolder.AutoSize = true;
            this.cbMetaSubfolder.Location = new System.Drawing.Point(120, 506);
            this.cbMetaSubfolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMetaSubfolder.Name = "cbMetaSubfolder";
            this.cbMetaSubfolder.Size = new System.Drawing.Size(388, 29);
            this.cbMetaSubfolder.TabIndex = 11;
            this.cbMetaSubfolder.Text = "Place py&TiVo Meta files in subfolder";
            this.cbMetaSubfolder.UseVisualStyleBackColor = true;
            // 
            // cbMeta
            // 
            this.cbMeta.AutoSize = true;
            this.cbMeta.Location = new System.Drawing.Point(80, 462);
            this.cbMeta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMeta.Name = "cbMeta";
            this.cbMeta.Size = new System.Drawing.Size(334, 29);
            this.cbMeta.TabIndex = 10;
            this.cbMeta.Text = "py&TiVo Meta files for episodes";
            this.cbMeta.UseVisualStyleBackColor = true;
            this.cbMeta.CheckedChanged += new System.EventHandler(this.cbMeta_CheckedChanged);
            // 
            // rbFolderFanArt
            // 
            this.rbFolderFanArt.AutoSize = true;
            this.rbFolderFanArt.Location = new System.Drawing.Point(80, 665);
            this.rbFolderFanArt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbFolderFanArt.Name = "rbFolderFanArt";
            this.rbFolderFanArt.Size = new System.Drawing.Size(113, 29);
            this.rbFolderFanArt.TabIndex = 15;
            this.rbFolderFanArt.TabStop = true;
            this.rbFolderFanArt.Text = "F&an Art";
            this.rbFolderFanArt.UseVisualStyleBackColor = true;
            // 
            // rbFolderPoster
            // 
            this.rbFolderPoster.AutoSize = true;
            this.rbFolderPoster.Location = new System.Drawing.Point(80, 627);
            this.rbFolderPoster.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbFolderPoster.Name = "rbFolderPoster";
            this.rbFolderPoster.Size = new System.Drawing.Size(105, 29);
            this.rbFolderPoster.TabIndex = 14;
            this.rbFolderPoster.TabStop = true;
            this.rbFolderPoster.Text = "&Poster";
            this.rbFolderPoster.UseVisualStyleBackColor = true;
            // 
            // rbFolderBanner
            // 
            this.rbFolderBanner.AutoSize = true;
            this.rbFolderBanner.Location = new System.Drawing.Point(80, 588);
            this.rbFolderBanner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbFolderBanner.Name = "rbFolderBanner";
            this.rbFolderBanner.Size = new System.Drawing.Size(112, 29);
            this.rbFolderBanner.TabIndex = 13;
            this.rbFolderBanner.TabStop = true;
            this.rbFolderBanner.Text = "&Banner";
            this.rbFolderBanner.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 25);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(272, 25);
            this.label28.TabIndex = 0;
            this.label28.Text = "\"Scan\" checks and actions:";
            // 
            // cbSearchRSS
            // 
            this.cbSearchRSS.AutoSize = true;
            this.cbSearchRSS.Location = new System.Drawing.Point(80, 329);
            this.cbSearchRSS.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbSearchRSS.Name = "cbSearchRSS";
            this.cbSearchRSS.Size = new System.Drawing.Size(316, 29);
            this.cbSearchRSS.TabIndex = 7;
            this.cbSearchRSS.Text = "&Search RSS for missing files";
            this.cbSearchRSS.UseVisualStyleBackColor = true;
            // 
            // cbEpImgs
            // 
            this.cbEpImgs.AutoSize = true;
            this.cbEpImgs.Location = new System.Drawing.Point(80, 373);
            this.cbEpImgs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbEpImgs.Name = "cbEpImgs";
            this.cbEpImgs.Size = new System.Drawing.Size(295, 29);
            this.cbEpImgs.TabIndex = 8;
            this.cbEpImgs.Text = "&Episode Thumbnails (.tbn)";
            this.cbEpImgs.UseVisualStyleBackColor = true;
            // 
            // cbNFOs
            // 
            this.cbNFOs.AutoSize = true;
            this.cbNFOs.Location = new System.Drawing.Point(80, 417);
            this.cbNFOs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbNFOs.Name = "cbNFOs";
            this.cbNFOs.Size = new System.Drawing.Size(433, 29);
            this.cbNFOs.TabIndex = 9;
            this.cbNFOs.Text = "&XBMC NFO files for shows and episodes";
            this.cbNFOs.UseVisualStyleBackColor = true;
            // 
            // cbFolderJpg
            // 
            this.cbFolderJpg.AutoSize = true;
            this.cbFolderJpg.Location = new System.Drawing.Point(40, 550);
            this.cbFolderJpg.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbFolderJpg.Name = "cbFolderJpg";
            this.cbFolderJpg.Size = new System.Drawing.Size(331, 29);
            this.cbFolderJpg.TabIndex = 12;
            this.cbFolderJpg.Text = "&Folder Thumbnails (folder.jpg)";
            this.cbFolderJpg.UseVisualStyleBackColor = true;
            // 
            // cbRenameCheck
            // 
            this.cbRenameCheck.AutoSize = true;
            this.cbRenameCheck.Checked = true;
            this.cbRenameCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRenameCheck.Location = new System.Drawing.Point(40, 63);
            this.cbRenameCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbRenameCheck.Name = "cbRenameCheck";
            this.cbRenameCheck.Size = new System.Drawing.Size(191, 29);
            this.cbRenameCheck.TabIndex = 1;
            this.cbRenameCheck.Text = "&Rename Check";
            this.cbRenameCheck.UseVisualStyleBackColor = true;
            // 
            // cbMissing
            // 
            this.cbMissing.AutoSize = true;
            this.cbMissing.Checked = true;
            this.cbMissing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMissing.Location = new System.Drawing.Point(40, 108);
            this.cbMissing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMissing.Name = "cbMissing";
            this.cbMissing.Size = new System.Drawing.Size(185, 29);
            this.cbMissing.TabIndex = 2;
            this.cbMissing.Text = "&Missing Check";
            this.cbMissing.UseVisualStyleBackColor = true;
            this.cbMissing.CheckedChanged += new System.EventHandler(this.cbMissing_CheckedChanged);
            // 
            // cbLeaveOriginals
            // 
            this.cbLeaveOriginals.AutoSize = true;
            this.cbLeaveOriginals.Location = new System.Drawing.Point(120, 196);
            this.cbLeaveOriginals.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbLeaveOriginals.Name = "cbLeaveOriginals";
            this.cbLeaveOriginals.Size = new System.Drawing.Size(255, 29);
            this.cbLeaveOriginals.TabIndex = 4;
            this.cbLeaveOriginals.Text = "&Copy files, don\'t move";
            this.cbLeaveOriginals.UseVisualStyleBackColor = true;
            // 
            // cbCheckSABnzbd
            // 
            this.cbCheckSABnzbd.AutoSize = true;
            this.cbCheckSABnzbd.Location = new System.Drawing.Point(80, 285);
            this.cbCheckSABnzbd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCheckSABnzbd.Name = "cbCheckSABnzbd";
            this.cbCheckSABnzbd.Size = new System.Drawing.Size(266, 29);
            this.cbCheckSABnzbd.TabIndex = 6;
            this.cbCheckSABnzbd.Text = "Check SA&Bnzbd queue";
            this.cbCheckSABnzbd.UseVisualStyleBackColor = true;
            this.cbCheckSABnzbd.CheckedChanged += new System.EventHandler(this.cbSearchLocally_CheckedChanged);
            // 
            // cbCheckuTorrent
            // 
            this.cbCheckuTorrent.AutoSize = true;
            this.cbCheckuTorrent.Location = new System.Drawing.Point(80, 240);
            this.cbCheckuTorrent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCheckuTorrent.Name = "cbCheckuTorrent";
            this.cbCheckuTorrent.Size = new System.Drawing.Size(258, 29);
            this.cbCheckuTorrent.TabIndex = 5;
            this.cbCheckuTorrent.Text = "C&heck µTorrent queue";
            this.cbCheckuTorrent.UseVisualStyleBackColor = true;
            this.cbCheckuTorrent.CheckedChanged += new System.EventHandler(this.cbSearchLocally_CheckedChanged);
            // 
            // cbSearchLocally
            // 
            this.cbSearchLocally.AutoSize = true;
            this.cbSearchLocally.Checked = true;
            this.cbSearchLocally.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSearchLocally.Location = new System.Drawing.Point(80, 152);
            this.cbSearchLocally.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbSearchLocally.Name = "cbSearchLocally";
            this.cbSearchLocally.Size = new System.Drawing.Size(424, 29);
            this.cbSearchLocally.TabIndex = 3;
            this.cbSearchLocally.Text = "&Look in \"Search Folders\" for mising files";
            this.cbSearchLocally.UseVisualStyleBackColor = true;
            this.cbSearchLocally.CheckedChanged += new System.EventHandler(this.cbSearchLocally_CheckedChanged);
            // 
            // tbSearchFolders
            // 
            this.tbSearchFolders.Controls.Add(this.cbMonitorFolder);
            this.tbSearchFolders.Controls.Add(this.bnOpenSearchFolder);
            this.tbSearchFolders.Controls.Add(this.bnRemoveSearchFolder);
            this.tbSearchFolders.Controls.Add(this.bnAddSearchFolder);
            this.tbSearchFolders.Controls.Add(this.lbSearchFolders);
            this.tbSearchFolders.Controls.Add(this.label23);
            this.tbSearchFolders.Location = new System.Drawing.Point(4, 124);
            this.tbSearchFolders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSearchFolders.Name = "tbSearchFolders";
            this.tbSearchFolders.Size = new System.Drawing.Size(840, 728);
            this.tbSearchFolders.TabIndex = 3;
            this.tbSearchFolders.Text = "Search Folders";
            this.tbSearchFolders.UseVisualStyleBackColor = true;
            // 
            // cbMonitorFolder
            // 
            this.cbMonitorFolder.AutoSize = true;
            this.cbMonitorFolder.Location = new System.Drawing.Point(498, 717);
            this.cbMonitorFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbMonitorFolder.Name = "cbMonitorFolder";
            this.cbMonitorFolder.Size = new System.Drawing.Size(306, 29);
            this.cbMonitorFolder.TabIndex = 5;
            this.cbMonitorFolder.Text = "&Monitor folders for changes";
            this.toolTip1.SetToolTip(this.cbMonitorFolder, "If the contents of any of these folder change, then automatically do a \"Scan\" and" +
        " \"Do\".");
            this.cbMonitorFolder.UseVisualStyleBackColor = true;
            // 
            // bnOpenSearchFolder
            // 
            this.bnOpenSearchFolder.Location = new System.Drawing.Point(336, 710);
            this.bnOpenSearchFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnOpenSearchFolder.Name = "bnOpenSearchFolder";
            this.bnOpenSearchFolder.Size = new System.Drawing.Size(150, 44);
            this.bnOpenSearchFolder.TabIndex = 4;
            this.bnOpenSearchFolder.Text = "&Open";
            this.bnOpenSearchFolder.UseVisualStyleBackColor = true;
            this.bnOpenSearchFolder.Click += new System.EventHandler(this.bnOpenSearchFolder_Click);
            // 
            // bnRemoveSearchFolder
            // 
            this.bnRemoveSearchFolder.Location = new System.Drawing.Point(174, 710);
            this.bnRemoveSearchFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnRemoveSearchFolder.Name = "bnRemoveSearchFolder";
            this.bnRemoveSearchFolder.Size = new System.Drawing.Size(150, 44);
            this.bnRemoveSearchFolder.TabIndex = 3;
            this.bnRemoveSearchFolder.Text = "&Remove";
            this.bnRemoveSearchFolder.UseVisualStyleBackColor = true;
            this.bnRemoveSearchFolder.Click += new System.EventHandler(this.bnRemoveSearchFolder_Click);
            // 
            // bnAddSearchFolder
            // 
            this.bnAddSearchFolder.Location = new System.Drawing.Point(6, 710);
            this.bnAddSearchFolder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnAddSearchFolder.Name = "bnAddSearchFolder";
            this.bnAddSearchFolder.Size = new System.Drawing.Size(150, 44);
            this.bnAddSearchFolder.TabIndex = 2;
            this.bnAddSearchFolder.Text = "&Add";
            this.bnAddSearchFolder.UseVisualStyleBackColor = true;
            this.bnAddSearchFolder.Click += new System.EventHandler(this.bnAddSearchFolder_Click);
            // 
            // lbSearchFolders
            // 
            this.lbSearchFolders.AllowDrop = true;
            this.lbSearchFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchFolders.FormattingEnabled = true;
            this.lbSearchFolders.ItemHeight = 25;
            this.lbSearchFolders.Location = new System.Drawing.Point(6, 44);
            this.lbSearchFolders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbSearchFolders.Name = "lbSearchFolders";
            this.lbSearchFolders.ScrollAlwaysVisible = true;
            this.lbSearchFolders.Size = new System.Drawing.Size(586, 654);
            this.lbSearchFolders.TabIndex = 1;
            this.lbSearchFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbSearchFolders_DragDrop);
            this.lbSearchFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.lbSearchFolders_DragOver);
            this.lbSearchFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSearchFolders_KeyDown);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 6);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(158, 25);
            this.label23.TabIndex = 0;
            this.label23.Text = "&Search Folders";
            // 
            // tbuTorrentNZB
            // 
            this.tbuTorrentNZB.Controls.Add(this.groupBox1);
            this.tbuTorrentNZB.Controls.Add(this.groupBox6);
            this.tbuTorrentNZB.Controls.Add(this.RSSGrid);
            this.tbuTorrentNZB.Controls.Add(this.bnRSSRemove);
            this.tbuTorrentNZB.Controls.Add(this.bnRSSAdd);
            this.tbuTorrentNZB.Controls.Add(this.bnRSSGo);
            this.tbuTorrentNZB.Controls.Add(this.label25);
            this.tbuTorrentNZB.Location = new System.Drawing.Point(4, 124);
            this.tbuTorrentNZB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbuTorrentNZB.Name = "tbuTorrentNZB";
            this.tbuTorrentNZB.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbuTorrentNZB.Size = new System.Drawing.Size(840, 728);
            this.tbuTorrentNZB.TabIndex = 4;
            this.tbuTorrentNZB.Text = "µTorrent / NZB";
            this.tbuTorrentNZB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSABHostPort);
            this.groupBox1.Controls.Add(this.txtSABAPIKey);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 394);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(818, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SABnzbd";
            // 
            // txtSABHostPort
            // 
            this.txtSABHostPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSABHostPort.Location = new System.Drawing.Point(150, 37);
            this.txtSABHostPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSABHostPort.Name = "txtSABHostPort";
            this.txtSABHostPort.Size = new System.Drawing.Size(490, 31);
            this.txtSABHostPort.TabIndex = 1;
            // 
            // txtSABAPIKey
            // 
            this.txtSABAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSABAPIKey.Location = new System.Drawing.Point(150, 92);
            this.txtSABAPIKey.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSABAPIKey.Name = "txtSABAPIKey";
            this.txtSABAPIKey.Size = new System.Drawing.Size(490, 31);
            this.txtSABAPIKey.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "API Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Host:Port";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bnUTBrowseResumeDat);
            this.groupBox6.Controls.Add(this.txtUTResumeDatPath);
            this.groupBox6.Controls.Add(this.bnRSSBrowseuTorrent);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.txtRSSuTorrentPath);
            this.groupBox6.Location = new System.Drawing.Point(6, 562);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Size = new System.Drawing.Size(818, 154);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "µTorrent";
            // 
            // bnUTBrowseResumeDat
            // 
            this.bnUTBrowseResumeDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnUTBrowseResumeDat.Location = new System.Drawing.Point(656, 88);
            this.bnUTBrowseResumeDat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnUTBrowseResumeDat.Name = "bnUTBrowseResumeDat";
            this.bnUTBrowseResumeDat.Size = new System.Drawing.Size(150, 44);
            this.bnUTBrowseResumeDat.TabIndex = 5;
            this.bnUTBrowseResumeDat.Text = "Bro&wse...";
            this.bnUTBrowseResumeDat.UseVisualStyleBackColor = true;
            this.bnUTBrowseResumeDat.Click += new System.EventHandler(this.bnUTBrowseResumeDat_Click);
            // 
            // txtUTResumeDatPath
            // 
            this.txtUTResumeDatPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUTResumeDatPath.Location = new System.Drawing.Point(150, 92);
            this.txtUTResumeDatPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUTResumeDatPath.Name = "txtUTResumeDatPath";
            this.txtUTResumeDatPath.Size = new System.Drawing.Size(490, 31);
            this.txtUTResumeDatPath.TabIndex = 4;
            // 
            // bnRSSBrowseuTorrent
            // 
            this.bnRSSBrowseuTorrent.Location = new System.Drawing.Point(656, 33);
            this.bnRSSBrowseuTorrent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnRSSBrowseuTorrent.Name = "bnRSSBrowseuTorrent";
            this.bnRSSBrowseuTorrent.Size = new System.Drawing.Size(150, 44);
            this.bnRSSBrowseuTorrent.TabIndex = 2;
            this.bnRSSBrowseuTorrent.Text = "&Browse...";
            this.bnRSSBrowseuTorrent.UseVisualStyleBackColor = true;
            this.bnRSSBrowseuTorrent.Click += new System.EventHandler(this.bnRSSBrowseuTorrent_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 42);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 25);
            this.label27.TabIndex = 0;
            this.label27.Text = "A&pplication:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 98);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 25);
            this.label26.TabIndex = 3;
            this.label26.Text = "resume.&dat:";
            // 
            // txtRSSuTorrentPath
            // 
            this.txtRSSuTorrentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRSSuTorrentPath.Location = new System.Drawing.Point(150, 37);
            this.txtRSSuTorrentPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRSSuTorrentPath.Name = "txtRSSuTorrentPath";
            this.txtRSSuTorrentPath.Size = new System.Drawing.Size(490, 31);
            this.txtRSSuTorrentPath.TabIndex = 1;
            // 
            // RSSGrid
            // 
            this.RSSGrid.BackColor = System.Drawing.SystemColors.Window;
            this.RSSGrid.EnableSort = true;
            this.RSSGrid.Location = new System.Drawing.Point(6, 69);
            this.RSSGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RSSGrid.Name = "RSSGrid";
            this.RSSGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.RSSGrid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.RSSGrid.Size = new System.Drawing.Size(818, 262);
            this.RSSGrid.TabIndex = 1;
            this.RSSGrid.TabStop = true;
            this.RSSGrid.ToolTipText = "";
            // 
            // bnRSSRemove
            // 
            this.bnRSSRemove.Location = new System.Drawing.Point(168, 342);
            this.bnRSSRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnRSSRemove.Name = "bnRSSRemove";
            this.bnRSSRemove.Size = new System.Drawing.Size(150, 44);
            this.bnRSSRemove.TabIndex = 3;
            this.bnRSSRemove.Text = "&Remove";
            this.bnRSSRemove.UseVisualStyleBackColor = true;
            this.bnRSSRemove.Click += new System.EventHandler(this.bnRSSRemove_Click);
            // 
            // bnRSSAdd
            // 
            this.bnRSSAdd.Location = new System.Drawing.Point(6, 342);
            this.bnRSSAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnRSSAdd.Name = "bnRSSAdd";
            this.bnRSSAdd.Size = new System.Drawing.Size(150, 44);
            this.bnRSSAdd.TabIndex = 2;
            this.bnRSSAdd.Text = "&Add";
            this.bnRSSAdd.UseVisualStyleBackColor = true;
            this.bnRSSAdd.Click += new System.EventHandler(this.bnRSSAdd_Click);
            // 
            // bnRSSGo
            // 
            this.bnRSSGo.Location = new System.Drawing.Point(330, 342);
            this.bnRSSGo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnRSSGo.Name = "bnRSSGo";
            this.bnRSSGo.Size = new System.Drawing.Size(150, 44);
            this.bnRSSGo.TabIndex = 4;
            this.bnRSSGo.Text = "&Open";
            this.bnRSSGo.UseVisualStyleBackColor = true;
            this.bnRSSGo.Click += new System.EventHandler(this.bnRSSGo_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 25);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(195, 25);
            this.label25.TabIndex = 0;
            this.label25.Text = "Torrent RSS URLs:";
            // 
            // tpTreeColoring
            // 
            this.tpTreeColoring.Controls.Add(this.label7);
            this.tpTreeColoring.Controls.Add(this.cboShowStatus);
            this.tpTreeColoring.Controls.Add(this.label5);
            this.tpTreeColoring.Controls.Add(this.txtShowStatusColor);
            this.tpTreeColoring.Controls.Add(this.btnSelectColor);
            this.tpTreeColoring.Controls.Add(this.bnRemoveDefinedColor);
            this.tpTreeColoring.Controls.Add(this.btnAddShowStatusColoring);
            this.tpTreeColoring.Controls.Add(this.lvwDefinedColors);
            this.tpTreeColoring.Location = new System.Drawing.Point(4, 124);
            this.tpTreeColoring.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpTreeColoring.Name = "tpTreeColoring";
            this.tpTreeColoring.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpTreeColoring.Size = new System.Drawing.Size(840, 728);
            this.tpTreeColoring.TabIndex = 7;
            this.tpTreeColoring.Text = "Tree Coloring";
            this.tpTreeColoring.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 631);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "&Status:";
            // 
            // cboShowStatus
            // 
            this.cboShowStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShowStatus.FormattingEnabled = true;
            this.cboShowStatus.Location = new System.Drawing.Point(102, 625);
            this.cboShowStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboShowStatus.Name = "cboShowStatus";
            this.cboShowStatus.Size = new System.Drawing.Size(626, 33);
            this.cboShowStatus.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 692);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Text Color:";
            // 
            // txtShowStatusColor
            // 
            this.txtShowStatusColor.Location = new System.Drawing.Point(134, 687);
            this.txtShowStatusColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtShowStatusColor.Name = "txtShowStatusColor";
            this.txtShowStatusColor.Size = new System.Drawing.Size(196, 31);
            this.txtShowStatusColor.TabIndex = 5;
            this.txtShowStatusColor.TextChanged += new System.EventHandler(this.txtShowStatusColor_TextChanged);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(346, 683);
            this.btnSelectColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(150, 44);
            this.btnSelectColor.TabIndex = 4;
            this.btnSelectColor.Text = "Select &Color";
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // bnRemoveDefinedColor
            // 
            this.bnRemoveDefinedColor.Enabled = false;
            this.bnRemoveDefinedColor.Location = new System.Drawing.Point(12, 569);
            this.bnRemoveDefinedColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bnRemoveDefinedColor.Name = "bnRemoveDefinedColor";
            this.bnRemoveDefinedColor.Size = new System.Drawing.Size(150, 44);
            this.bnRemoveDefinedColor.TabIndex = 3;
            this.bnRemoveDefinedColor.Text = "&Remove";
            this.bnRemoveDefinedColor.UseVisualStyleBackColor = true;
            this.bnRemoveDefinedColor.Click += new System.EventHandler(this.bnRemoveDefinedColor_Click);
            // 
            // btnAddShowStatusColoring
            // 
            this.btnAddShowStatusColoring.Location = new System.Drawing.Point(582, 683);
            this.btnAddShowStatusColoring.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddShowStatusColoring.Name = "btnAddShowStatusColoring";
            this.btnAddShowStatusColoring.Size = new System.Drawing.Size(150, 44);
            this.btnAddShowStatusColoring.TabIndex = 3;
            this.btnAddShowStatusColoring.Text = "&Add";
            this.btnAddShowStatusColoring.UseVisualStyleBackColor = true;
            this.btnAddShowStatusColoring.Click += new System.EventHandler(this.btnAddShowStatusColoring_Click);
            // 
            // lvwDefinedColors
            // 
            this.lvwDefinedColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colShowStatus,
            this.colColor});
            this.lvwDefinedColors.GridLines = true;
            this.lvwDefinedColors.Location = new System.Drawing.Point(12, 12);
            this.lvwDefinedColors.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvwDefinedColors.MultiSelect = false;
            this.lvwDefinedColors.Name = "lvwDefinedColors";
            this.lvwDefinedColors.Size = new System.Drawing.Size(794, 542);
            this.lvwDefinedColors.TabIndex = 0;
            this.lvwDefinedColors.UseCompatibleStateImageBehavior = false;
            this.lvwDefinedColors.View = System.Windows.Forms.View.Details;
            this.lvwDefinedColors.SelectedIndexChanged += new System.EventHandler(this.lvwDefinedColors_SelectedIndexChanged);
            this.lvwDefinedColors.DoubleClick += new System.EventHandler(this.lvwDefinedColors_DoubleClick);
            // 
            // colShowStatus
            // 
            this.colShowStatus.Text = "Show Status";
            this.colShowStatus.Width = 297;
            // 
            // colColor
            // 
            this.colColor.Text = "Color";
            this.colColor.Width = 92;
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // openFile
            // 
            this.openFile.Filter = "Torrent files (*.torrent)|*.torrent|All files (*.*)|*.*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 500);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Embeded Artwork Path:";
            // 
            // txtArtworkPath
            // 
            this.txtArtworkPath.Location = new System.Drawing.Point(250, 497);
            this.txtArtworkPath.Name = "txtArtworkPath";
            this.txtArtworkPath.Size = new System.Drawing.Size(432, 31);
            this.txtArtworkPath.TabIndex = 19;
            // 
            // Preferences
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.bnCancel;
            this.ClientSize = new System.Drawing.Size(896, 969);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Preferences";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Preferences_FormClosing);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbGeneral.ResumeLayout(false);
            this.tbGeneral.PerformLayout();
            this.tbFilesAndFolders.ResumeLayout(false);
            this.tbFilesAndFolders.PerformLayout();
            this.tbAutoExport.ResumeLayout(false);
            this.tbAutoExport.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpScanOptions.ResumeLayout(false);
            this.tpScanOptions.PerformLayout();
            this.tbSearchFolders.ResumeLayout(false);
            this.tbSearchFolders.PerformLayout();
            this.tbuTorrentNZB.ResumeLayout(false);
            this.tbuTorrentNZB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpTreeColoring.ResumeLayout(false);
            this.tpTreeColoring.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabPage tpScanOptions;
        private System.Windows.Forms.CheckBox cbSearchRSS;
        private System.Windows.Forms.CheckBox cbEpImgs;
        private System.Windows.Forms.CheckBox cbNFOs;
        private System.Windows.Forms.CheckBox cbFolderJpg;
        private System.Windows.Forms.CheckBox cbRenameCheck;
        private System.Windows.Forms.CheckBox cbMissing;
        private System.Windows.Forms.CheckBox cbLeaveOriginals;
        private System.Windows.Forms.CheckBox cbSearchLocally;
        private System.Windows.Forms.Label label28;
        private SourceGrid.Grid ReplacementsGrid;
        private System.Windows.Forms.Button bnReplaceRemove;
        private System.Windows.Forms.Button bnReplaceAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCheckuTorrent;
        private System.Windows.Forms.CheckBox cbAutoSelInMyShows;
        private System.Windows.Forms.RadioButton rbFolderFanArt;
        private System.Windows.Forms.RadioButton rbFolderPoster;
        private System.Windows.Forms.RadioButton rbFolderBanner;

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button bnCancel;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnBrowseWTWRSS;
        private System.Windows.Forms.TextBox txtWTWRSS;

        private System.Windows.Forms.CheckBox cbWTWRSS;
        private System.Windows.Forms.SaveFileDialog saveFile;

        private System.Windows.Forms.TextBox txtWTWDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStartupTab;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.CheckBox cbNotificationIcon;
        private System.Windows.Forms.TextBox txtVideoExtensions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtExportRSSMaxDays;

        private System.Windows.Forms.TextBox txtExportRSSMaxShows;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbKeepTogether;
        private System.Windows.Forms.CheckBox cbLeadingZero;
        private System.Windows.Forms.CheckBox chkShowInTaskbar;
        private System.Windows.Forms.CheckBox cbTxtToSub;
        private System.Windows.Forms.CheckBox cbShowEpisodePictures;
        private System.Windows.Forms.TextBox txtSpecialsFolderName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbGeneral;
        private System.Windows.Forms.TabPage tbFilesAndFolders;
        private System.Windows.Forms.TabPage tbAutoExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bnBrowseMissingCSV;
        private System.Windows.Forms.CheckBox cbMissingCSV;
        private System.Windows.Forms.TextBox txtMissingCSV;
        private System.Windows.Forms.Button bnBrowseMissingXML;
        private System.Windows.Forms.CheckBox cbMissingXML;
        private System.Windows.Forms.TextBox txtMissingXML;
        private System.Windows.Forms.Button bnBrowseFOXML;

        private System.Windows.Forms.CheckBox cbFOXML;
        private System.Windows.Forms.TextBox txtFOXML;
            
        private System.Windows.Forms.Button bnBrowseRenamingXML;
        private System.Windows.Forms.CheckBox cbRenamingXML;
        private System.Windows.Forms.TextBox txtRenamingXML;
        private System.Windows.Forms.CheckBox cbIgnoreSamples;

        private System.Windows.Forms.CheckBox cbForceLower;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMaxSampleSize;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtParallelDownloads;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtOtherExtensions;
        private System.Windows.Forms.TabPage tbSearchFolders;
        private System.Windows.Forms.Button bnOpenSearchFolder;
        private System.Windows.Forms.Button bnRemoveSearchFolder;
        private System.Windows.Forms.Button bnAddSearchFolder;
        private System.Windows.Forms.ListBox lbSearchFolders;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TabPage tbuTorrentNZB;
        private System.Windows.Forms.Button bnRSSBrowseuTorrent;
        private System.Windows.Forms.Button bnRSSGo;
        private System.Windows.Forms.TextBox txtRSSuTorrentPath;
              
        private System.Windows.Forms.Label label25;
        private SourceGrid.Grid RSSGrid;

        private System.Windows.Forms.Button bnRSSRemove;
        private System.Windows.Forms.Button bnRSSAdd;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bnUTBrowseResumeDat;
        private System.Windows.Forms.TextBox txtUTResumeDatPath;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox cbLookForAirdate;
        private System.Windows.Forms.CheckBox cbMonitorFolder;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tpTreeColoring;
        private System.Windows.Forms.ListView lvwDefinedColors;
        private System.Windows.Forms.ColumnHeader colShowStatus;
        private System.Windows.Forms.ColumnHeader colColor;
        private System.Windows.Forms.TextBox txtShowStatusColor;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Button btnAddShowStatusColoring;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboShowStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bnRemoveDefinedColor;
        private System.Windows.Forms.CheckBox cbMeta;
        private System.Windows.Forms.CheckBox cbMetaSubfolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExportRSSDaysPast;
        private System.Windows.Forms.Button bnBrowseWTWXML;
        private System.Windows.Forms.TextBox txtWTWXML;
        private System.Windows.Forms.CheckBox cbWTWXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSABHostPort;
        private System.Windows.Forms.TextBox txtSABAPIKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbCheckSABnzbd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLanguages;
        private System.Windows.Forms.RadioButton rbWTWScan;
        private System.Windows.Forms.RadioButton rbWTWSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtArtworkPath;

    }
}