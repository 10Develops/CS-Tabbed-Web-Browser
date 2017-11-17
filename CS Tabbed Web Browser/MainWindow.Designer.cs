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
            System.Windows.Forms.ToolStripLabel addressLabel;
            System.Windows.Forms.ToolStripMenuItem openMenuItem;
            System.Windows.Forms.ToolStripButton homeButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ToolStripButton newTabButton;
            System.Windows.Forms.ToolStripMenuItem exitMenuItem;
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.closeTabButton = new System.Windows.Forms.ToolStripButton();
            this.addressTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSearchInGoogle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchInBing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchInYahoo = new System.Windows.Forms.ToolStripMenuItem();
            this.hamburgerMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmsProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewSourceTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new CS_Tabbed_Web_Browser.WebBrowserTabControl();
            toolbarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolbarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            addressLabel = new System.Windows.Forms.ToolStripLabel();
            openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            homeButton = new System.Windows.Forms.ToolStripButton();
            newTabButton = new System.Windows.Forms.ToolStripButton();
            exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.cms.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.cmsProperties.SuspendLayout();
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
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(26, 22);
            addressLabel.Text = "Site";
            // 
            // openMenuItem
            // 
            openMenuItem.Enabled = false;
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openMenuItem.Size = new System.Drawing.Size(163, 22);
            openMenuItem.Text = "&Open...";
            openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // homeButton
            // 
            homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            homeButton.Name = "homeButton";
            homeButton.Size = new System.Drawing.Size(23, 22);
            homeButton.Text = "Home";
            homeButton.Visible = false;
            homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // newTabButton
            // 
            newTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            newTabButton.Image = ((System.Drawing.Image)(resources.GetObject("newTabButton.Image")));
            newTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            newTabButton.Name = "newTabButton";
            newTabButton.Size = new System.Drawing.Size(23, 22);
            newTabButton.Text = "New Tab";
            newTabButton.ToolTipText = "New Tab (Ctrl + T)";
            newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.exitMenuItem_Image;
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new System.Drawing.Size(163, 22);
            exitMenuItem.Text = "E&xit";
            exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.historyMenuItem,
            this.toolsMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenu.Size = new System.Drawing.Size(674, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.Visible = false;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabMenuItem,
            openMenuItem,
            this.closeTabMenuItem,
            this.fileMenuSeparator1,
            exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // newTabMenuItem
            // 
            this.newTabMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.newTabMenuItem_Image;
            this.newTabMenuItem.Name = "newTabMenuItem";
            this.newTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTabMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newTabMenuItem.Text = "&New Tab";
            this.newTabMenuItem.Click += new System.EventHandler(this.newTabMenuItem_Click);
            // 
            // closeTabMenuItem
            // 
            this.closeTabMenuItem.Enabled = false;
            this.closeTabMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.closeTabMenuItem_Image;
            this.closeTabMenuItem.Name = "closeTabMenuItem";
            this.closeTabMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeTabMenuItem.Text = "&Close Tab";
            this.closeTabMenuItem.Click += new System.EventHandler(this.closeTabMenuItem_Click);
            // 
            // fileMenuSeparator1
            // 
            this.fileMenuSeparator1.Name = "fileMenuSeparator1";
            this.fileMenuSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenuItem,
            this.stopMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "&View";
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Enabled = false;
            this.refreshMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.refreshMenuItem_Image;
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshMenuItem.Size = new System.Drawing.Size(154, 22);
            this.refreshMenuItem.Text = "&Refresh";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Enabled = false;
            this.stopMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.stopMenuItem_Image;
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stopMenuItem.Text = "&Stop";
            this.stopMenuItem.Click += new System.EventHandler(this.stopMenuItem_Click);
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem,
            this.forwardMenuItem,
            this.homeMenuItem});
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyMenuItem.Text = "Hi&story";
            // 
            // backMenuItem
            // 
            this.backMenuItem.Enabled = false;
            this.backMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.backMenuItem_Image;
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.backMenuItem.Size = new System.Drawing.Size(179, 22);
            this.backMenuItem.Text = "&Back";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // forwardMenuItem
            // 
            this.forwardMenuItem.Enabled = false;
            this.forwardMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.forwardMenuItem_Image;
            this.forwardMenuItem.Name = "forwardMenuItem";
            this.forwardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.forwardMenuItem.Size = new System.Drawing.Size(179, 22);
            this.forwardMenuItem.Text = "For&ward";
            this.forwardMenuItem.Click += new System.EventHandler(this.forwardMenuItem_Click);
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.homeMenuItem_Image;
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.homeMenuItem.Size = new System.Drawing.Size(179, 22);
            this.homeMenuItem.Text = "H&ome";
            this.homeMenuItem.Click += new System.EventHandler(this.homeMenuItem_Click);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsMenuItem.Text = "&Tools";
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.optionsMenuItem_Image;
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsMenuItem.Text = "&Options...";
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatesMenuItem,
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // updatesMenuItem
            // 
            this.updatesMenuItem.Name = "updatesMenuItem";
            this.updatesMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updatesMenuItem.Text = "&Updates";
            this.updatesMenuItem.Click += new System.EventHandler(this.updatesMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
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
            homeButton,
            toolbarSeparator1,
            newTabButton,
            this.closeTabButton,
            toolbarSeparator2,
            addressLabel,
            this.addressTextBox,
            this.goButton,
            this.searchButton,
            this.hamburgerMenuButton});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbar.Size = new System.Drawing.Size(674, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowMenuStrip});
            this.cms.Name = "cms";
            this.cms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cms.Size = new System.Drawing.Size(165, 26);
            // 
            // tsmiShowMenuStrip
            // 
            this.tsmiShowMenuStrip.Name = "tsmiShowMenuStrip";
            this.tsmiShowMenuStrip.Size = new System.Drawing.Size(164, 22);
            this.tsmiShowMenuStrip.Text = "Show Menu Strip";
            this.tsmiShowMenuStrip.Click += new System.EventHandler(this.tsmiShowMenuStrip_Click);
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
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
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
            this.searchButton.ToolTipText = "Search in the Web (Ctrl + S)";
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
            this.tsmiSearchInYahoo.Text = "Search in Yhoo";
            this.tsmiSearchInYahoo.Click += new System.EventHandler(this.tsmiSearchInYahoo_Click);
            // 
            // hamburgerMenuButton
            // 
            this.hamburgerMenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hamburgerMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hamburgerMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions,
            this.updatesTSMI,
            this.aboutTSMI});
            this.hamburgerMenuButton.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.hamburgerMenuItem_Image;
            this.hamburgerMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hamburgerMenuButton.Name = "hamburgerMenuButton";
            this.hamburgerMenuButton.Size = new System.Drawing.Size(29, 22);
            this.hamburgerMenuButton.Text = "More";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.optionsMenuItem_Image;
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(152, 22);
            this.tsmiOptions.Text = "Options";
            this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
            // 
            // updatesTSMI
            // 
            this.updatesTSMI.Name = "updatesTSMI";
            this.updatesTSMI.Size = new System.Drawing.Size(152, 22);
            this.updatesTSMI.Text = "Updates";
            this.updatesTSMI.Click += new System.EventHandler(this.updatesTSMI_Click);
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(152, 22);
            this.aboutTSMI.Text = "About";
            this.aboutTSMI.Click += new System.EventHandler(this.aboutTSMI_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 373);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(674, 20);
            this.pnlStatus.TabIndex = 4;
            this.pnlStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(4, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "label1";
            // 
            // cmsProperties
            // 
            this.cmsProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backTSMI,
            this.forwardTSMI,
            this.refreshTSMI,
            this.toolStripMenuItem1,
            this.printTSMI,
            this.toolStripMenuItem2,
            this.viewSourceTSMI});
            this.cmsProperties.Name = "cmsProperties";
            this.cmsProperties.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsProperties.Size = new System.Drawing.Size(139, 126);
            // 
            // backTSMI
            // 
            this.backTSMI.Enabled = false;
            this.backTSMI.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.backMenuItem_Image;
            this.backTSMI.Name = "backTSMI";
            this.backTSMI.Size = new System.Drawing.Size(138, 22);
            this.backTSMI.Text = "Back";
            this.backTSMI.Click += new System.EventHandler(this.backTSMI_Click);
            // 
            // forwardTSMI
            // 
            this.forwardTSMI.Enabled = false;
            this.forwardTSMI.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.forwardMenuItem_Image;
            this.forwardTSMI.Name = "forwardTSMI";
            this.forwardTSMI.Size = new System.Drawing.Size(138, 22);
            this.forwardTSMI.Text = "Forward";
            this.forwardTSMI.Click += new System.EventHandler(this.forwardTSMI_Click);
            // 
            // refreshTSMI
            // 
            this.refreshTSMI.Enabled = false;
            this.refreshTSMI.Image = global::CS_Tabbed_Web_Browser.Properties.Resources.refreshMenuItem_Image;
            this.refreshTSMI.Name = "refreshTSMI";
            this.refreshTSMI.Size = new System.Drawing.Size(138, 22);
            this.refreshTSMI.Text = "Refresh";
            this.refreshTSMI.Click += new System.EventHandler(this.refreshTSMI_Click);
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
            this.viewSourceTSMI.Enabled = false;
            this.viewSourceTSMI.Name = "viewSourceTSMI";
            this.viewSourceTSMI.Size = new System.Drawing.Size(138, 22);
            this.viewSourceTSMI.Text = "View Source";
            this.viewSourceTSMI.Visible = false;
            // 
            // tabs
            // 
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 25);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(674, 348);
            this.tabs.TabIndex = 3;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 393);
            this.ContextMenuStrip = this.cms;
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "Tabbed Web Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.cms.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.cmsProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripButton closeTabButton;
        private System.Windows.Forms.ToolStripButton goButton;
        private WebBrowserTabControl tabs;
        private System.Windows.Forms.ToolStripMenuItem newTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowMenuStrip;
        private System.Windows.Forms.ToolStripSplitButton searchButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchInGoogle;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchInBing;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchInYahoo;
        private System.Windows.Forms.ToolStripDropDownButton hamburgerMenuButton;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripTextBox addressTextBox;
        private System.Windows.Forms.ContextMenuStrip cmsProperties;
        private System.Windows.Forms.ToolStripMenuItem backTSMI;
        private System.Windows.Forms.ToolStripMenuItem forwardTSMI;
        private System.Windows.Forms.ToolStripMenuItem refreshTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewSourceTSMI;
        private System.Windows.Forms.ToolStripMenuItem updatesTSMI;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
    }
}