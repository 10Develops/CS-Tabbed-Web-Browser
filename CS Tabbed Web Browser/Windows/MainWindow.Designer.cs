namespace CS_Tabbed_Web_Browser
{
    partial class MainWindow
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
            System.Windows.Forms.ToolStripSeparator toolbarSeparator1;
            System.Windows.Forms.ToolStripSeparator toolbarSeparator2;
            System.Windows.Forms.ToolStripDropDownButton addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.typeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showCertTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabButton = new System.Windows.Forms.ToolStripButton();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showProgressBarTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusBarTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.closeTabButton = new System.Windows.Forms.ToolStripButton();
            this.addressTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSearchInGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchInBing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchInYahoo = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburgerMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.historyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.updatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.bookmarkThisPageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BookmarksTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.allBookmarksTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearBookmarksTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmsGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewSourceTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.cmsTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLink = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenNewTabTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.copyLinkTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new CS_Tabbed_Web_Browser.WebBrowserTabControl();
            this.addTabButton = new System.Windows.Forms.TabPage();
            toolbarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolbarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            addressLabel = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbar.SuspendLayout();
            this.cms.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.cmsGeneral.SuspendLayout();
            this.pnlProgressBar.SuspendLayout();
            this.cmsTabs.SuspendLayout();
            this.cmsText.SuspendLayout();
            this.cmsLink.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarSeparator1
            // 
            toolbarSeparator1.Name = "toolbarSeparator1";
            toolbarSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbarSeparator2
            // 
            toolbarSeparator2.Name = "toolbarSeparator2";
            toolbarSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addressLabel
            // 
            addressLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeTSMI,
            this.showCertTSMI});
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(39, 22);
            addressLabel.Text = "Site";
            // 
            // typeTSMI
            // 
            this.typeTSMI.Name = "typeTSMI";
            this.typeTSMI.Size = new System.Drawing.Size(160, 22);
            this.typeTSMI.Text = "Type of the Site";
            // 
            // showCertTSMI
            // 
            this.showCertTSMI.Name = "showCertTSMI";
            this.showCertTSMI.Size = new System.Drawing.Size(160, 22);
            this.showCertTSMI.Text = "Show Certificate";
            this.showCertTSMI.Visible = false;
            this.showCertTSMI.Click += new System.EventHandler(this.showCertTSMI_Click);
            // 
            // newTabButton
            // 
            this.newTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTabButton.Image = ((System.Drawing.Image)(resources.GetObject("newTabButton.Image")));
            this.newTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(23, 22);
            this.newTabButton.Text = "New Tab";
            this.newTabButton.ToolTipText = "New Tab (Ctrl+T)";
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // toolbar
            // 
            this.toolbar.ContextMenuStrip = this.cms;
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.refreshButton,
            this.stopButton,
            this.homeButton,
            toolbarSeparator1,
            this.newTabButton,
            this.closeTabButton,
            toolbarSeparator2,
            addressLabel,
            this.addressTextBox,
            this.goButton,
            this.searchButton,
            this.hamburgerMenuButton,
            this.bookmarkButton});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbar.Size = new System.Drawing.Size(685, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProgressBarTSMI,
            this.showStatusBarTSMI});
            this.cms.Name = "cms";
            this.cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cms.Size = new System.Drawing.Size(172, 48);
            // 
            // showProgressBarTSMI
            // 
            this.showProgressBarTSMI.Checked = true;
            this.showProgressBarTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showProgressBarTSMI.Name = "showProgressBarTSMI";
            this.showProgressBarTSMI.Size = new System.Drawing.Size(171, 22);
            this.showProgressBarTSMI.Text = "Show Progress Bar";
            this.showProgressBarTSMI.Click += new System.EventHandler(this.showProgressBarTSMI_Click);
            // 
            // showStatusBarTSMI
            // 
            this.showStatusBarTSMI.Checked = true;
            this.showStatusBarTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStatusBarTSMI.Name = "showStatusBarTSMI";
            this.showStatusBarTSMI.Size = new System.Drawing.Size(171, 22);
            this.showStatusBarTSMI.Text = "Show Status Bar";
            this.showStatusBarTSMI.Click += new System.EventHandler(this.showStatusBarTSMI_Click);
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Enabled = false;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 22);
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Enabled = false;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 22);
            this.forwardButton.Text = "Forward";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Enabled = false;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.ToolTipText = "Refresh (F5)";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Enabled = false;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(23, 22);
            this.stopButton.Text = "Text";
            this.stopButton.ToolTipText = "Stop";
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(23, 22);
            this.homeButton.Text = "Home";
            this.homeButton.Visible = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // closeTabButton
            // 
            this.closeTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTabButton.Enabled = false;
            this.closeTabButton.Image = ((System.Drawing.Image)(resources.GetObject("closeTabButton.Image")));
            this.closeTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(23, 22);
            this.closeTabButton.Text = "Close Tab";
            this.closeTabButton.ToolTipText = "Close Tab";
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressTextBox.AutoSize = false;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(325, 25);
            this.addressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTextBox_KeyDown);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(23, 22);
            this.goButton.Text = "Go";
            this.goButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.goButton.ToolTipText = "Go (Enter)";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearchInGoogle,
            this.tsmiSearchInBing,
            this.tsmiSearchInYahoo});
            this.searchButton.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.searchGoogleMenuItem_Image;
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 22);
            this.searchButton.Text = "Search in Google";
            this.searchButton.ToolTipText = "Search in the Web (Ctrl+S)";
            this.searchButton.ButtonClick += new System.EventHandler(this.searchButton_ButtonClick);
            // 
            // tsmiSearchInGoogle
            // 
            this.tsmiSearchInGoogle.Name = "tsmiSearchInGoogle";
            this.tsmiSearchInGoogle.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchInGoogle.Text = "Search in Google";
            this.tsmiSearchInGoogle.Click += new System.EventHandler(this.tsmiSearchInGoogle_Click);
            // 
            // tsmiSearchInBing
            // 
            this.tsmiSearchInBing.Name = "tsmiSearchInBing";
            this.tsmiSearchInBing.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchInBing.Text = "Search in Bing";
            this.tsmiSearchInBing.Click += new System.EventHandler(this.tsmiSearchInBing_Click);
            // 
            // tsmiSearchInYahoo
            // 
            this.tsmiSearchInYahoo.Name = "tsmiSearchInYahoo";
            this.tsmiSearchInYahoo.Size = new System.Drawing.Size(163, 22);
            this.tsmiSearchInYahoo.Text = "Search in Yahoo";
            this.tsmiSearchInYahoo.Click += new System.EventHandler(this.tsmiSearchInYahoo_Click);
            // 
            // hamburgerMenuButton
            // 
            this.hamburgerMenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hamburgerMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hamburgerMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyTSMI,
            this.developerToolsTSMI,
            this.toolStripMenuItem3,
            this.updatesTSMI,
            this.tsmiOptions,
            this.aboutTSMI});
            this.hamburgerMenuButton.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.hamburgerMenuItem_Image;
            this.hamburgerMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hamburgerMenuButton.Name = "hamburgerMenuButton";
            this.hamburgerMenuButton.Size = new System.Drawing.Size(29, 22);
            this.hamburgerMenuButton.Text = "More";
            // 
            // historyTSMI
            // 
            this.historyTSMI.Name = "historyTSMI";
            this.historyTSMI.Size = new System.Drawing.Size(157, 22);
            this.historyTSMI.Text = "History";
            this.historyTSMI.Click += new System.EventHandler(this.historyTSMI_Click);
            // 
            // developerToolsTSMI
            // 
            this.developerToolsTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleTSMI,
            this.viewSourceDropDown});
            this.developerToolsTSMI.Name = "developerToolsTSMI";
            this.developerToolsTSMI.Size = new System.Drawing.Size(157, 22);
            this.developerToolsTSMI.Text = "Developer Tools";
            // 
            // consoleTSMI
            // 
            this.consoleTSMI.Name = "consoleTSMI";
            this.consoleTSMI.Size = new System.Drawing.Size(138, 22);
            this.consoleTSMI.Text = "Console";
            this.consoleTSMI.Click += new System.EventHandler(this.consoleTSMI_Click);
            // 
            // viewSourceDropDown
            // 
            this.viewSourceDropDown.Name = "viewSourceDropDown";
            this.viewSourceDropDown.Size = new System.Drawing.Size(138, 22);
            this.viewSourceDropDown.Text = "View Source";
            this.viewSourceDropDown.Click += new System.EventHandler(this.viewSourceDropDown_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 6);
            // 
            // updatesTSMI
            // 
            this.updatesTSMI.Name = "updatesTSMI";
            this.updatesTSMI.Size = new System.Drawing.Size(157, 22);
            this.updatesTSMI.Text = "Updates";
            this.updatesTSMI.Click += new System.EventHandler(this.updatesTSMI_Click);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(157, 22);
            this.tsmiOptions.Text = "Options";
            this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(157, 22);
            this.aboutTSMI.Text = "About";
            this.aboutTSMI.Click += new System.EventHandler(this.aboutTSMI_Click);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkThisPageTSMI,
            this.BookmarksTSMI,
            this.ClearBookmarksTSMI});
            this.bookmarkButton.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.bookmarkMenuItem_Image;
            this.bookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(29, 22);
            this.bookmarkButton.Text = "Bookmark";
            // 
            // bookmarkThisPageTSMI
            // 
            this.bookmarkThisPageTSMI.Name = "bookmarkThisPageTSMI";
            this.bookmarkThisPageTSMI.Size = new System.Drawing.Size(180, 22);
            this.bookmarkThisPageTSMI.Text = "Bookmark this Page";
            this.bookmarkThisPageTSMI.Click += new System.EventHandler(this.bookmarkThisPageTSMI_Click);
            // 
            // BookmarksTSMI
            // 
            this.BookmarksTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBookmarksTSMI});
            this.BookmarksTSMI.Name = "BookmarksTSMI";
            this.BookmarksTSMI.Size = new System.Drawing.Size(180, 22);
            this.BookmarksTSMI.Text = "Bookmarks";
            this.BookmarksTSMI.DropDownOpening += new System.EventHandler(this.BookmarksTSMI_DropDownOpening);
            // 
            // allBookmarksTSMI
            // 
            this.allBookmarksTSMI.Name = "allBookmarksTSMI";
            this.allBookmarksTSMI.Size = new System.Drawing.Size(150, 22);
            this.allBookmarksTSMI.Text = "All Bookmarks";
            this.allBookmarksTSMI.Click += new System.EventHandler(this.allBookmarksTSMI_Click);
            // 
            // ClearBookmarksTSMI
            // 
            this.ClearBookmarksTSMI.Name = "ClearBookmarksTSMI";
            this.ClearBookmarksTSMI.Size = new System.Drawing.Size(180, 22);
            this.ClearBookmarksTSMI.Text = "Clear Bookmarks";
            this.ClearBookmarksTSMI.Click += new System.EventHandler(this.ClearBookmarksTSMI_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 475);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(685, 20);
            this.pnlStatus.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(4, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // cmsGeneral
            // 
            this.cmsGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backTSMI,
            this.forwardTSMI,
            this.refreshTSMI,
            this.toolStripMenuItem6,
            this.selectAllTSMI,
            this.toolStripMenuItem1,
            this.printTSMI,
            this.toolStripMenuItem2,
            this.viewSourceTSMI});
            this.cmsGeneral.Name = "cmsProperties";
            this.cmsGeneral.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsGeneral.Size = new System.Drawing.Size(139, 154);
            // 
            // backTSMI
            // 
            this.backTSMI.Enabled = false;
            this.backTSMI.Name = "backTSMI";
            this.backTSMI.Size = new System.Drawing.Size(138, 22);
            this.backTSMI.Text = "Back";
            this.backTSMI.Click += new System.EventHandler(this.backTSMI_Click);
            // 
            // forwardTSMI
            // 
            this.forwardTSMI.Enabled = false;
            this.forwardTSMI.Name = "forwardTSMI";
            this.forwardTSMI.Size = new System.Drawing.Size(138, 22);
            this.forwardTSMI.Text = "Forward";
            this.forwardTSMI.Click += new System.EventHandler(this.forwardTSMI_Click);
            // 
            // refreshTSMI
            // 
            this.refreshTSMI.Enabled = false;
            this.refreshTSMI.Name = "refreshTSMI";
            this.refreshTSMI.Size = new System.Drawing.Size(138, 22);
            this.refreshTSMI.Text = "Refresh";
            this.refreshTSMI.Click += new System.EventHandler(this.refreshTSMI_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(135, 6);
            // 
            // selectAllTSMI
            // 
            this.selectAllTSMI.Name = "selectAllTSMI";
            this.selectAllTSMI.Size = new System.Drawing.Size(138, 22);
            this.selectAllTSMI.Text = "Select All";
            this.selectAllTSMI.Click += new System.EventHandler(this.selectAllTSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 6);
            // 
            // printTSMI
            // 
            this.printTSMI.Enabled = false;
            this.printTSMI.Name = "printTSMI";
            this.printTSMI.Size = new System.Drawing.Size(138, 22);
            this.printTSMI.Text = "Print";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(135, 6);
            // 
            // viewSourceTSMI
            // 
            this.viewSourceTSMI.Name = "viewSourceTSMI";
            this.viewSourceTSMI.Size = new System.Drawing.Size(138, 22);
            this.viewSourceTSMI.Text = "View Source";
            this.viewSourceTSMI.Click += new System.EventHandler(this.viewSourceTSMI_Click);
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.Controls.Add(this.pnlProgress);
            this.pnlProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgressBar.Location = new System.Drawing.Point(0, 25);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(685, 10);
            this.pnlProgressBar.TabIndex = 5;
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.Green;
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgress.Location = new System.Drawing.Point(0, 0);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(0, 10);
            this.pnlProgress.TabIndex = 0;
            // 
            // cmsTabs
            // 
            this.cmsTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabTSMI,
            this.closeTabTSMI});
            this.cmsTabs.Name = "cmsTabs";
            this.cmsTabs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsTabs.Size = new System.Drawing.Size(168, 48);
            // 
            // newTabTSMI
            // 
            this.newTabTSMI.Name = "newTabTSMI";
            this.newTabTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabTSMI.Size = new System.Drawing.Size(167, 22);
            this.newTabTSMI.Text = "New Tab";
            this.newTabTSMI.Click += new System.EventHandler(this.newTabTSMI_Click);
            // 
            // closeTabTSMI
            // 
            this.closeTabTSMI.Enabled = false;
            this.closeTabTSMI.Name = "closeTabTSMI";
            this.closeTabTSMI.Size = new System.Drawing.Size(167, 22);
            this.closeTabTSMI.Text = "Close Current Tab";
            this.closeTabTSMI.Click += new System.EventHandler(this.closeTabTSMI_Click);
            // 
            // cmsText
            // 
            this.cmsText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTSMI,
            this.searchTSMI});
            this.cmsText.Name = "cmsText";
            this.cmsText.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsText.Size = new System.Drawing.Size(110, 48);
            // 
            // copyTSMI
            // 
            this.copyTSMI.Name = "copyTSMI";
            this.copyTSMI.Size = new System.Drawing.Size(109, 22);
            this.copyTSMI.Text = "Copy";
            this.copyTSMI.Click += new System.EventHandler(this.copyTSMI_Click);
            // 
            // searchTSMI
            // 
            this.searchTSMI.Name = "searchTSMI";
            this.searchTSMI.Size = new System.Drawing.Size(109, 22);
            this.searchTSMI.Text = "Search";
            this.searchTSMI.Click += new System.EventHandler(this.searchTSMI_Click);
            // 
            // cmsLink
            // 
            this.cmsLink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTSMI,
            this.OpenNewTabTSMI,
            this.toolStripMenuItem7,
            this.copyLinkTSMI});
            this.cmsLink.Name = "cmsText";
            this.cmsLink.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsLink.Size = new System.Drawing.Size(168, 76);
            // 
            // OpenTSMI
            // 
            this.OpenTSMI.Name = "OpenTSMI";
            this.OpenTSMI.Size = new System.Drawing.Size(167, 22);
            this.OpenTSMI.Text = "Open";
            // 
            // OpenNewTabTSMI
            // 
            this.OpenNewTabTSMI.Name = "OpenNewTabTSMI";
            this.OpenNewTabTSMI.Size = new System.Drawing.Size(167, 22);
            this.OpenNewTabTSMI.Text = "Open in new tab";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(164, 6);
            // 
            // copyLinkTSMI
            // 
            this.copyLinkTSMI.Name = "copyLinkTSMI";
            this.copyLinkTSMI.Size = new System.Drawing.Size(167, 22);
            this.copyLinkTSMI.Text = "Copy link address";
            // 
            // tabs
            // 
            this.tabs.ContextMenuStrip = this.cmsTabs;
            this.tabs.Controls.Add(this.addTabButton);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ItemSize = new System.Drawing.Size(0, 24);
            this.tabs.Location = new System.Drawing.Point(0, 35);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(685, 440);
            this.tabs.TabIndex = 3;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            this.tabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabs_Selecting);
            this.tabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabs_MouseDown);
            // 
            // addTabButton
            // 
            this.addTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addTabButton.Location = new System.Drawing.Point(4, 28);
            this.addTabButton.Name = "addTabButton";
            this.addTabButton.Padding = new System.Windows.Forms.Padding(3);
            this.addTabButton.Size = new System.Drawing.Size(677, 408);
            this.addTabButton.TabIndex = 1;
            this.addTabButton.Text = "  +";
            this.addTabButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 495);
            this.ContextMenuStrip = this.cms;
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.pnlProgressBar);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Tabbed Web Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.cms.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.cmsGeneral.ResumeLayout(false);
            this.pnlProgressBar.ResumeLayout(false);
            this.cmsTabs.ResumeLayout(false);
            this.cmsText.ResumeLayout(false);
            this.cmsLink.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton closeTabButton;
        private System.Windows.Forms.ToolStripButton goButton;
        private WebBrowserTabControl tabs;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripSplitButton searchButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchInGoogle;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchInBing;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchInYahoo;
        private System.Windows.Forms.ToolStripDropDownButton hamburgerMenuButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripTextBox addressTextBox;
        private System.Windows.Forms.ContextMenuStrip cmsGeneral;
        private System.Windows.Forms.ToolStripMenuItem backTSMI;
        private System.Windows.Forms.ToolStripMenuItem forwardTSMI;
        private System.Windows.Forms.ToolStripMenuItem refreshTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewSourceTSMI;
        private System.Windows.Forms.ToolStripMenuItem updatesTSMI;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.ToolStripMenuItem typeTSMI;
        private System.Windows.Forms.ToolStripMenuItem historyTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ToolStripMenuItem showProgressBarTSMI;
        private System.Windows.Forms.ToolStripMenuItem showStatusBarTSMI;
        private System.Windows.Forms.ToolStripButton homeButton;
        private System.Windows.Forms.ContextMenuStrip cmsTabs;
        private System.Windows.Forms.ToolStripMenuItem newTabTSMI;
        private System.Windows.Forms.ToolStripMenuItem closeTabTSMI;
        private System.Windows.Forms.ToolStripMenuItem developerToolsTSMI;
        private System.Windows.Forms.ToolStripMenuItem consoleTSMI;
        private System.Windows.Forms.ToolStripMenuItem viewSourceDropDown;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem selectAllTSMI;
        private System.Windows.Forms.ContextMenuStrip cmsText;
        private System.Windows.Forms.ToolStripMenuItem copyTSMI;
        private System.Windows.Forms.ToolStripMenuItem searchTSMI;
        private System.Windows.Forms.ContextMenuStrip cmsLink;
        private System.Windows.Forms.ToolStripMenuItem OpenNewTabTSMI;
        private System.Windows.Forms.ToolStripMenuItem OpenTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem copyLinkTSMI;
        private System.Windows.Forms.ToolStripMenuItem showCertTSMI;
        private System.Windows.Forms.TabPage addTabButton;
        private System.Windows.Forms.ToolStripDropDownButton bookmarkButton;
        private System.Windows.Forms.ToolStripMenuItem bookmarkThisPageTSMI;
        private System.Windows.Forms.ToolStripMenuItem BookmarksTSMI;
        private System.Windows.Forms.ToolStripButton newTabButton;
        private System.Windows.Forms.ToolStripMenuItem ClearBookmarksTSMI;
        private System.Windows.Forms.ToolStripMenuItem allBookmarksTSMI;
    }
}