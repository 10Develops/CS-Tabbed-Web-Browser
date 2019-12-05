namespace CS_Tabbed_Web_Browser
{
    partial class OptionsDialogue
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
            System.Windows.Forms.Button cancelOperationButton;
            System.Windows.Forms.Button okButton;
            System.Windows.Forms.Button useBlankAsHomePageButton;
            System.Windows.Forms.Button useCurrentAsHomePageButton;
            System.Windows.Forms.Label homePageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialogue));
            this.tc = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.gbDynamic = new System.Windows.Forms.GroupBox();
            this.dynamicProgressBarToggle = new System.Windows.Forms.CheckBox();
            this.dynamicStatusBarToggle = new System.Windows.Forms.CheckBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbSearchEngine = new System.Windows.Forms.ComboBox();
            this.lblDefaultSearchEngine = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.showHomeButtonToggle = new System.Windows.Forms.CheckBox();
            this.startupWithHomePageToggle = new System.Windows.Forms.CheckBox();
            this.homePageText = new System.Windows.Forms.TextBox();
            this.tpNet = new System.Windows.Forms.TabPage();
            this.gbProxy = new System.Windows.Forms.GroupBox();
            this.rbUseProxy = new System.Windows.Forms.RadioButton();
            this.rbNoUseProxy = new System.Windows.Forms.RadioButton();
            this.tbProxy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            cancelOperationButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            useBlankAsHomePageButton = new System.Windows.Forms.Button();
            useCurrentAsHomePageButton = new System.Windows.Forms.Button();
            homePageLabel = new System.Windows.Forms.Label();
            this.tc.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.gbDynamic.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gb.SuspendLayout();
            this.tpNet.SuspendLayout();
            this.gbProxy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelOperationButton
            // 
            cancelOperationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelOperationButton.Location = new System.Drawing.Point(313, 5);
            cancelOperationButton.Name = "cancelOperationButton";
            cancelOperationButton.Size = new System.Drawing.Size(75, 23);
            cancelOperationButton.TabIndex = 14;
            cancelOperationButton.Text = "Cancel";
            cancelOperationButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Location = new System.Drawing.Point(236, 5);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 13;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // useBlankAsHomePageButton
            // 
            useBlankAsHomePageButton.Location = new System.Drawing.Point(156, 44);
            useBlankAsHomePageButton.Name = "useBlankAsHomePageButton";
            useBlankAsHomePageButton.Size = new System.Drawing.Size(75, 23);
            useBlankAsHomePageButton.TabIndex = 16;
            useBlankAsHomePageButton.Text = "Use &Blank";
            useBlankAsHomePageButton.UseVisualStyleBackColor = true;
            useBlankAsHomePageButton.Click += new System.EventHandler(this.useBlankAsHomePageButton_Click);
            // 
            // useCurrentAsHomePageButton
            // 
            useCurrentAsHomePageButton.Location = new System.Drawing.Point(75, 44);
            useCurrentAsHomePageButton.Name = "useCurrentAsHomePageButton";
            useCurrentAsHomePageButton.Size = new System.Drawing.Size(75, 23);
            useCurrentAsHomePageButton.TabIndex = 15;
            useCurrentAsHomePageButton.Text = "Use &Current";
            useCurrentAsHomePageButton.UseVisualStyleBackColor = true;
            useCurrentAsHomePageButton.Click += new System.EventHandler(this.useCurrentAsHomePageButton_Click);
            // 
            // homePageLabel
            // 
            homePageLabel.AutoSize = true;
            homePageLabel.Location = new System.Drawing.Point(3, 21);
            homePageLabel.Name = "homePageLabel";
            homePageLabel.Size = new System.Drawing.Size(66, 13);
            homePageLabel.TabIndex = 13;
            homePageLabel.Text = "&Home Page:";
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tpGeneral);
            this.tc.Controls.Add(this.tpNet);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(393, 334);
            this.tc.TabIndex = 15;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.gbDynamic);
            this.tpGeneral.Controls.Add(this.gbSearch);
            this.tpGeneral.Controls.Add(this.gb);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(385, 308);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // gbDynamic
            // 
            this.gbDynamic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDynamic.Controls.Add(this.dynamicProgressBarToggle);
            this.gbDynamic.Controls.Add(this.dynamicStatusBarToggle);
            this.gbDynamic.Location = new System.Drawing.Point(3, 185);
            this.gbDynamic.Name = "gbDynamic";
            this.gbDynamic.Size = new System.Drawing.Size(379, 44);
            this.gbDynamic.TabIndex = 20;
            this.gbDynamic.TabStop = false;
            this.gbDynamic.Text = "Dynamic Elements";
            // 
            // dynamicProgressBarToggle
            // 
            this.dynamicProgressBarToggle.AutoSize = true;
            this.dynamicProgressBarToggle.Location = new System.Drawing.Point(207, 19);
            this.dynamicProgressBarToggle.Name = "dynamicProgressBarToggle";
            this.dynamicProgressBarToggle.Size = new System.Drawing.Size(166, 17);
            this.dynamicProgressBarToggle.TabIndex = 20;
            this.dynamicProgressBarToggle.Text = "&Enable Dynamic Progress Bar";
            this.dynamicProgressBarToggle.UseVisualStyleBackColor = true;
            // 
            // dynamicStatusBarToggle
            // 
            this.dynamicStatusBarToggle.AutoSize = true;
            this.dynamicStatusBarToggle.Location = new System.Drawing.Point(6, 19);
            this.dynamicStatusBarToggle.Name = "dynamicStatusBarToggle";
            this.dynamicStatusBarToggle.Size = new System.Drawing.Size(155, 17);
            this.dynamicStatusBarToggle.TabIndex = 19;
            this.dynamicStatusBarToggle.Text = "&Enable Dynamic Status Bar";
            this.dynamicStatusBarToggle.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.cbSearchEngine);
            this.gbSearch.Controls.Add(this.lblDefaultSearchEngine);
            this.gbSearch.Location = new System.Drawing.Point(3, 122);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(379, 61);
            this.gbSearch.TabIndex = 19;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Engine";
            // 
            // cbSearchEngine
            // 
            this.cbSearchEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchEngine.FormattingEnabled = true;
            this.cbSearchEngine.Items.AddRange(new object[] {
            "Google",
            "Bing",
            "Yahoo"});
            this.cbSearchEngine.Location = new System.Drawing.Point(126, 23);
            this.cbSearchEngine.Name = "cbSearchEngine";
            this.cbSearchEngine.Size = new System.Drawing.Size(248, 21);
            this.cbSearchEngine.TabIndex = 1;
            // 
            // lblDefaultSearchEngine
            // 
            this.lblDefaultSearchEngine.AutoSize = true;
            this.lblDefaultSearchEngine.Location = new System.Drawing.Point(3, 26);
            this.lblDefaultSearchEngine.Name = "lblDefaultSearchEngine";
            this.lblDefaultSearchEngine.Size = new System.Drawing.Size(117, 13);
            this.lblDefaultSearchEngine.TabIndex = 0;
            this.lblDefaultSearchEngine.Text = "&Default Search Engine:";
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb.Controls.Add(this.showHomeButtonToggle);
            this.gb.Controls.Add(this.startupWithHomePageToggle);
            this.gb.Controls.Add(homePageLabel);
            this.gb.Controls.Add(useBlankAsHomePageButton);
            this.gb.Controls.Add(useCurrentAsHomePageButton);
            this.gb.Controls.Add(this.homePageText);
            this.gb.Location = new System.Drawing.Point(3, 3);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(379, 117);
            this.gb.TabIndex = 18;
            this.gb.TabStop = false;
            this.gb.Text = "Home Page";
            // 
            // showHomeButtonToggle
            // 
            this.showHomeButtonToggle.AutoSize = true;
            this.showHomeButtonToggle.Location = new System.Drawing.Point(75, 96);
            this.showHomeButtonToggle.Name = "showHomeButtonToggle";
            this.showHomeButtonToggle.Size = new System.Drawing.Size(115, 17);
            this.showHomeButtonToggle.TabIndex = 18;
            this.showHomeButtonToggle.Text = "&Show home button";
            this.showHomeButtonToggle.UseVisualStyleBackColor = true;
            // 
            // startupWithHomePageToggle
            // 
            this.startupWithHomePageToggle.AutoSize = true;
            this.startupWithHomePageToggle.Location = new System.Drawing.Point(75, 73);
            this.startupWithHomePageToggle.Name = "startupWithHomePageToggle";
            this.startupWithHomePageToggle.Size = new System.Drawing.Size(153, 17);
            this.startupWithHomePageToggle.TabIndex = 17;
            this.startupWithHomePageToggle.Text = "&Load home page at startup";
            this.startupWithHomePageToggle.UseVisualStyleBackColor = true;
            // 
            // homePageText
            // 
            this.homePageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homePageText.Location = new System.Drawing.Point(75, 18);
            this.homePageText.Name = "homePageText";
            this.homePageText.Size = new System.Drawing.Size(299, 20);
            this.homePageText.TabIndex = 14;
            // 
            // tpNet
            // 
            this.tpNet.Controls.Add(this.gbProxy);
            this.tpNet.Location = new System.Drawing.Point(4, 22);
            this.tpNet.Name = "tpNet";
            this.tpNet.Padding = new System.Windows.Forms.Padding(3);
            this.tpNet.Size = new System.Drawing.Size(385, 308);
            this.tpNet.TabIndex = 1;
            this.tpNet.Text = "Network";
            this.tpNet.UseVisualStyleBackColor = true;
            // 
            // gbProxy
            // 
            this.gbProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProxy.Controls.Add(this.rbUseProxy);
            this.gbProxy.Controls.Add(this.rbNoUseProxy);
            this.gbProxy.Controls.Add(this.tbProxy);
            this.gbProxy.Controls.Add(this.label1);
            this.gbProxy.Location = new System.Drawing.Point(3, 6);
            this.gbProxy.Name = "gbProxy";
            this.gbProxy.Size = new System.Drawing.Size(379, 116);
            this.gbProxy.TabIndex = 20;
            this.gbProxy.TabStop = false;
            this.gbProxy.Text = "Proxy Server";
            // 
            // rbUseProxy
            // 
            this.rbUseProxy.AutoSize = true;
            this.rbUseProxy.Location = new System.Drawing.Point(113, 26);
            this.rbUseProxy.Name = "rbUseProxy";
            this.rbUseProxy.Size = new System.Drawing.Size(72, 17);
            this.rbUseProxy.TabIndex = 3;
            this.rbUseProxy.Text = "&Use proxy";
            this.rbUseProxy.UseVisualStyleBackColor = true;
            // 
            // rbNoUseProxy
            // 
            this.rbNoUseProxy.AutoSize = true;
            this.rbNoUseProxy.Checked = true;
            this.rbNoUseProxy.Location = new System.Drawing.Point(9, 26);
            this.rbNoUseProxy.Name = "rbNoUseProxy";
            this.rbNoUseProxy.Size = new System.Drawing.Size(98, 17);
            this.rbNoUseProxy.TabIndex = 2;
            this.rbNoUseProxy.TabStop = true;
            this.rbNoUseProxy.Text = "&Don\'t use proxy";
            this.rbNoUseProxy.UseVisualStyleBackColor = true;
            this.rbNoUseProxy.CheckedChanged += new System.EventHandler(this.rbNoUseProxy_CheckedChanged);
            // 
            // tbProxy
            // 
            this.tbProxy.Enabled = false;
            this.tbProxy.Location = new System.Drawing.Point(9, 82);
            this.tbProxy.Name = "tbProxy";
            this.tbProxy.Size = new System.Drawing.Size(364, 20);
            this.tbProxy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Proxy Server: (Format: IP Address:Port)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(cancelOperationButton);
            this.panel1.Controls.Add(okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 34);
            this.panel1.TabIndex = 16;
            // 
            // OptionsDialogue
            // 
            this.AcceptButton = okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelOperationButton;
            this.ClientSize = new System.Drawing.Size(393, 368);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsDialogue_Load);
            this.tc.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.gbDynamic.ResumeLayout(false);
            this.gbDynamic.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.tpNet.ResumeLayout(false);
            this.gbProxy.ResumeLayout(false);
            this.gbProxy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.CheckBox showHomeButtonToggle;
        private System.Windows.Forms.CheckBox startupWithHomePageToggle;
        private System.Windows.Forms.TextBox homePageText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ComboBox cbSearchEngine;
        private System.Windows.Forms.Label lblDefaultSearchEngine;
        private System.Windows.Forms.TabPage tpNet;
        private System.Windows.Forms.GroupBox gbProxy;
        private System.Windows.Forms.TextBox tbProxy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUseProxy;
        private System.Windows.Forms.RadioButton rbNoUseProxy;
        private System.Windows.Forms.GroupBox gbDynamic;
        private System.Windows.Forms.CheckBox dynamicProgressBarToggle;
        private System.Windows.Forms.CheckBox dynamicStatusBarToggle;
    }
}