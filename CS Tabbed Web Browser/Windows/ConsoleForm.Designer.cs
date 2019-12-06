namespace CS_Tabbed_Web_Browser
{
    partial class ConsoleForm
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
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Location = new System.Drawing.Point(0, 0);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(454, 380);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.btnEnter);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 380);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(454, 30);
            this.pnlAction.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(376, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "&Enter";
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 410);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.pnlAction);
            this.Name = "ConsoleForm";
            this.ShowIcon = false;
            this.Text = "Console";
            this.pnlAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnEnter;
    }
}