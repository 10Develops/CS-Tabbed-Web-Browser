using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using CS_Tabbed_Web_Browser.Properties;
namespace CS_Tabbed_Web_Browser
{
    public partial class OptionsDialogue : Form
    {
        #region Variables

        /// <summary>
        /// The addressed currently displayed in the browser.
        /// </summary>
        private string currentAddress;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="OptionsDialogue" /> class.
        /// </summary>
        /// <param name="currentAddress">
        /// A <b>String</b> containing the address of the page currently displayed in the browser.
        /// </param>
        public OptionsDialogue(string currentAddress)
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.

            this.currentAddress = currentAddress;
        }

        #endregion

        #region Event Handlers
        private void OptionsDialogue_Load(object sender, EventArgs e)
        {
            // Load the current options
            this.homePageText.Text = Settings.Default.HomePage;
            this.startupWithHomePageToggle.Checked = Settings.Default.StartWithHomePage;
            showHomeButtonToggle.Checked = Settings.Default.ShowHomePage;
            dynamicStatusBarToggle.Checked = Settings.Default.ShowStatusBar;
            dynamicProgressBarToggle.Checked = Settings.Default.ShowProgressBar;
            cbSearchEngine.SelectedIndex = Settings.Default.DefaultSearchEngine;

            if(Settings.Default.UseProxy == true)
            {
                rbUseProxy.Checked = true;
                tbProxy.Text = Settings.Default.Proxy;
            }
            else
            {
                rbNoUseProxy.Checked = true;
                tbProxy.Enabled = false;
            }
        }

        private void useCurrentAsHomePageButton_Click(object sender, EventArgs e)
        {
            this.homePageText.Text = this.currentAddress;
        }

        private void useBlankAsHomePageButton_Click(object sender, EventArgs e)
        {
            this.homePageText.Clear();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Save the new settings
            Settings.Default.HomePage = this.homePageText.Text;
            Settings.Default.StartWithHomePage = this.startupWithHomePageToggle.Checked;
            Settings.Default.ShowHomePage = showHomeButtonToggle.Checked;
            Settings.Default.EnableDynamicStatusBar = dynamicStatusBarToggle.Checked;
            Settings.Default.EnableDynamicProgressBar = dynamicProgressBarToggle.Checked;
            Settings.Default.DefaultSearchEngine = cbSearchEngine.SelectedIndex;

            if (rbUseProxy.Checked == true)
            {
                if (!string.IsNullOrEmpty(tbProxy.Text))
                {
                    var ValidIpAddressPortRegex = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]):[\d]+$";
                    if (System.Text.RegularExpressions.Regex.IsMatch(tbProxy.Text, ValidIpAddressPortRegex))
                    {
                        Settings.Default.Proxy = tbProxy.Text;
                        Settings.Default.UseProxy = true;
                    }
                    else
                    {
                        MessageBox.Show("IP:PORT url not valid!","Information");
                    }
                }
                else
                {
                    Settings.Default.UseProxy = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tbProxy.Text))
                {
                    Settings.Default.Proxy = tbProxy.Text;
                }
                    Settings.Default.UseProxy = false;
            }
            Settings.Default.Save();
            Close();
        }
        private void rbNoUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            tbProxy.Enabled = !rbNoUseProxy.Checked;
        }

        #endregion
    }
}
