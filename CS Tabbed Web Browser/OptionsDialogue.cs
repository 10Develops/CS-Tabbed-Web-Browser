using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
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
            this.homePageText.Text = Properties.Settings.Default.HomePage;
            this.startupWithHomePageToggle.Checked = Properties.Settings.Default.StartWithHomePage;
            cbShowHomeButton.Checked = Properties.Settings.Default.ShowHomePage;
            cbSearchEngine.SelectedIndex = Properties.Settings.Default.DefaultSearchEngine;
                if(Properties.Settings.Default.UseProxy == true)
                {
                    rbUseProxy.Checked = true;
                    tbProxy.Text = Properties.Settings.Default.Proxy;
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
            Properties.Settings.Default.HomePage = this.homePageText.Text;
            Properties.Settings.Default.StartWithHomePage = this.startupWithHomePageToggle.Checked;
            Properties.Settings.Default.ShowHomePage = cbShowHomeButton.Checked;
            Properties.Settings.Default.DefaultSearchEngine = cbSearchEngine.SelectedIndex;
            if(rbUseProxy.Checked == true)
            {
                if (!string.IsNullOrEmpty(tbProxy.Text))
                {
                    var ValidIpAddressPortRegex = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]):[\d]+$";
                    if (System.Text.RegularExpressions.Regex.IsMatch(tbProxy.Text, ValidIpAddressPortRegex))
                    {
                        Properties.Settings.Default.Proxy = tbProxy.Text;
                        Properties.Settings.Default.UseProxy = true;
                    }
                    else
                    {
                        MessageBox.Show("IP:PORT url not valid!","Information");
                    }
                }
                else
                {
                    Properties.Settings.Default.UseProxy = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tbProxy.Text))
                {
                    Properties.Settings.Default.Proxy = tbProxy.Text;
                }
                    Properties.Settings.Default.UseProxy = false;
            }
            Properties.Settings.Default.Save();
            Close();
        }
        private void rbNoUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            tbProxy.Enabled = !rbNoUseProxy.Checked;
        }
        #endregion


    }
}
