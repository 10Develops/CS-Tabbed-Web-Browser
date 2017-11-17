using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_Tabbed_Web_Browser
{
    /// <summary>
    /// The main window for the tabbed web browser application.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Variables

        /// <summary>
        /// The difference in width between the window and the address field in the tool bar.
        /// </summary>
        private readonly int addressFieldSizeOffset;

        /// <summary>
        /// The <b>WebBrowser</b> control on the current tab.
        /// </summary>
        private WebBrowserCore currentBrowser;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            this.KeyPreview = true;
            // Add any initialization after the InitializeComponent() call.

            // Get the initial difference between the form width and address field width.
            // This value will be maintained as the window width changes.
            this.addressFieldSizeOffset = this.Width - this.addressTextBox.Width;
        }

        #endregion

        #region Event Handlers

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Add the default Tab
            this.tabs.AddTab();
            this.currentBrowser = this.tabs.SelectedWebBrowser;

            if (Properties.Settings.Default.StartWithHomePage && !string.IsNullOrEmpty(Properties.Settings.Default.HomePage))
            {
                GoToSite(Properties.Settings.Default.HomePage);
            }

            if (Properties.Settings.Default.Width != 0)
            {
                Width = Properties.Settings.Default.Width;
            }

            if (Properties.Settings.Default.Height != 0)
            {
                Height = Properties.Settings.Default.Height;
            }

            if (Properties.Settings.Default.WindowState == 0)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (Properties.Settings.Default.WindowState == 2)
            {
                WindowState = FormWindowState.Maximized;
            }

            currentBrowser.ContextMenuStrip = cmsProperties;
            homeMenuItem.Visible = Properties.Settings.Default.ShowHomePage;
            tsmiShowMenuStrip.Checked = Properties.Settings.Default.ShowMenuStrip;
            MainMenuStrip.Visible = Properties.Settings.Default.ShowMenuStrip;
            this.currentBrowser.StatusTextChanged += new EventHandler(currentBrowser_StatusTextChanged);
            this.currentBrowser.CanGoBackChanged += new EventHandler(currentBrowser_CanGoBackChanged);
            this.currentBrowser.CanGoForwardChanged += new EventHandler(currentBrowser_CanGoForwardChanged);
            this.currentBrowser.DocumentTitleChanged += new EventHandler(currentBrowser_DocumentTitleChanged);
            this.currentBrowser.Navigated += new WebBrowserNavigatedEventHandler(currentBrowser_Navigated);
            this.currentBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(currentBrowser_DocumentCompleted);
            currentBrowser.NewWindow += new CancelEventHandler(currentBrowser_NewWindow);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                addressTextBox.ShortcutsEnabled = true;
                currentBrowser.WebBrowserShortcutsEnabled = true;
                e.SuppressKeyPress = true;
                SearchInWeb(addressTextBox.Text);
            }
            if (e.Control && e.KeyCode == Keys.T)
            {
                addressTextBox.ShortcutsEnabled = true;
                currentBrowser.WebBrowserShortcutsEnabled = true;
                e.SuppressKeyPress = true;
                tabs.AddTab();
            }
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.addressFieldSizeOffset > 0)
            {
                // Maintain the original width difference between the form and the address
                // without allowing the address field to become less than 100 pixels wide.
                this.addressTextBox.Width = Math.Max(50, this.Width - this.addressFieldSizeOffset);
            }
        }

        private void addressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GoToSite(addressTextBox.Text);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            GoToSite(addressTextBox.Text);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current browser.
            this.currentBrowser = this.tabs.SelectedWebBrowser;

            this.DisplayPageTitle();

            // Enable the Close Tab command if and only if there is more than one tab.
            if (this.tabs.TabCount == 1)
            {
                this.closeTabMenuItem.Enabled = false;
                this.closeTabButton.Enabled = false;
            }
            else
            {
                this.closeTabMenuItem.Enabled = true;
                this.closeTabButton.Enabled = true;
            }

            Uri url = this.currentBrowser.Url;

            if (url == null)
            {
                // There is no current address.
                this.addressTextBox.Text = string.Empty;

                // The user cannot refresh a page that doesn't exist.
                this.refreshMenuItem.Enabled = false;
                this.refreshButton.Enabled = false;
                refreshTSMI.Enabled = false;
            }
            else
            {
                // Display the current page address in the address bar.
                this.addressTextBox.Text = url.ToString();

                // Allow the user to refresh the current page.
                this.refreshMenuItem.Enabled = true;
                this.refreshButton.Enabled = true;
                refreshTSMI.Enabled = true;
            }

            // Display the current page's status text in the status bar.
            if (currentBrowser.StatusText != "")
            {
                pnlStatus.Visible = true;
                this.lblStatus.Text = this.currentBrowser.StatusText;
            }
            else
            {
                pnlStatus.Visible = false;
            }
        }
        #region Main Menu Event Handlers

        #region File Menu Event Handler

        private void newTabMenuItem_Click(object sender, EventArgs e)
        {
            this.tabs.AddTab();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Prompt to open an address in the current tab.
        }

        private void closeTabMenuItem_Click(object sender, EventArgs e)
        {
            this.tabs.RemoveCurrentTab();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region View Menu Event Handler

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Refresh();
        }

        private void stopMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Stop();
        }

        #endregion

        #region History Menu Event Handler

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoBack();
        }

        private void forwardMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoForward();
        }

        private void homeMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.NavigateWeb(Properties.Settings.Default.HomePage);
        }

        private void tsmiShowMenuStrip_Click(object sender, EventArgs e)
        {
            tsmiShowMenuStrip.Checked = !tsmiShowMenuStrip.Checked;
            MainMenuStrip.Visible = tsmiShowMenuStrip.Checked;
            Properties.Settings.Default.ShowMenuStrip = tsmiShowMenuStrip.Checked;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            if(WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowState = 0;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                Properties.Settings.Default.WindowState = 0;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.WindowState = 2;
            }
                Properties.Settings.Default.Save();
        }

        private void tsmiSearchInGoogle_Click(object sender, EventArgs e)
        {
            SearchInGoogle(addressTextBox.Text);
        }

        private void tsmiSearchInBing_Click(object sender, EventArgs e)
        {
            SearchInBing(addressTextBox.Text);
        }

        private void tsmiSearchInYahoo_Click(object sender, EventArgs e)
        {
            SearchInYahoo(addressTextBox.Text);
        }

        private void searchButton_ButtonClick(object sender, EventArgs e)
        {
            SearchInWeb(addressTextBox.Text);
        }

        private void tsmiOptions_Click(object sender, EventArgs e)
        {
            optionsMenuItem.PerformClick();
        }

        private void updatesTSMI_Click(object sender, EventArgs e)
        {
            updatesMenuItem.PerformClick();
        }

        private void aboutTSMI_Click(object sender, EventArgs e)
        {
            aboutMenuItem.PerformClick();
        }

        private void backTSMI_Click(object sender, EventArgs e)
        {
            backMenuItem.PerformClick();
        }

        private void forwardTSMI_Click(object sender, EventArgs e)
        {
            forwardMenuItem.PerformClick();
        }

        private void refreshTSMI_Click(object sender, EventArgs e)
        {
            refreshMenuItem.PerformClick();
        }
        #endregion

        #region Tools Menu Event Handler

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            using (OptionsDialogue dialogue = new OptionsDialogue(this.currentBrowser.Url.ToString()))
            {
                dialogue.ShowDialog();
            }
        }

        #endregion

        #region Help Menu Event Handler

        private void updatesMenuItem_Click(object sender, EventArgs e)
        {
            UpdatesForm updatesForm = new UpdatesForm();
            updatesForm.Show();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
        #endregion

        #endregion

        #region Toolbar Event Handlers

        private void backButton_Click(object sender, EventArgs e)
        {
            this.backMenuItem.PerformClick();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            this.forwardMenuItem.PerformClick();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.refreshMenuItem.PerformClick();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.stopMenuItem.PerformClick();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.homeMenuItem.PerformClick();
        }

        private void newTabButton_Click(object sender, EventArgs e)
        {
            this.newTabMenuItem.PerformClick();
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            this.closeTabMenuItem.PerformClick();
        }

        #endregion

        #region Web Browser Event Handlers

        private void currentBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            // Display the current page's status text in the status bar.
            if (currentBrowser.StatusText != "")
            {
                pnlStatus.Visible = true;
                this.lblStatus.Text = this.currentBrowser.StatusText;
            }
            else
            {
                pnlStatus.Visible = false;
            }
        }

        private void currentBrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            bool canGoBack = this.currentBrowser.CanGoBack;

            this.backButton.Enabled = canGoBack;
            this.backMenuItem.Enabled = canGoBack;
            backTSMI.Enabled = canGoBack;
        }

        private void currentBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            bool canGoForward = this.currentBrowser.CanGoForward;

            this.forwardButton.Enabled = canGoForward;
            this.forwardMenuItem.Enabled = canGoForward;
            forwardTSMI.Enabled = canGoForward;
        }

        private void currentBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.DisplayPageTitle();
        }

        private void currentBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.addressTextBox.Text = this.currentBrowser.Url.ToString();
        }

        private void currentBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.refreshMenuItem.Enabled = true;
            this.refreshButton.Enabled = true;
            refreshTSMI.Enabled = true;
        }

        private void currentBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            try
            {
                HtmlElement link = currentBrowser.Document.ActiveElement;
                Uri urlNavigated = new Uri(link.GetAttribute("href"));
                tabs.AddTab();
                currentBrowser.NavigateWeb(urlNavigated.ToString());
                addressTextBox.Text = urlNavigated.ToString();
            }
            catch (UriFormatException){ }
            e.Cancel = true;
        }
        #endregion

        #endregion

        #region Methods

        /// <summary>
        /// Displays the current page title in the title bar.
        /// </summary>
        /// <remarks>
        /// Only the application name is displayed if no document is loaded.
        /// </remarks>
        private void DisplayPageTitle()
        {
            string documentTitle = this.currentBrowser.DocumentTitle;

            if (string.IsNullOrEmpty(documentTitle))
            {
                this.Text = Application.ProductName;
            }
            else
            {
                // Display the current page title in the window's title bar.
                this.Text = String.Format("{0} - {1}", documentTitle, Application.ProductName);
            }
        }
        private void SearchInWeb(string text)
        {
            if(Properties.Settings.Default.DefaultSearchEngine == 0)
            {
                SearchInGoogle(text);
            }

            if (Properties.Settings.Default.DefaultSearchEngine == 1)
            {
                SearchInBing(text);
            }

            if (Properties.Settings.Default.DefaultSearchEngine == 2)
            {
                SearchInYahoo(text);
            }
        }
        private void SearchInGoogle(string text)
        {
            GoToSite("https://www.google.com/search?q=" + text);
        }

        private void SearchInBing(string text)
        {
            GoToSite("https://www.bing.com/search?q=" + text);
        }

        private void SearchInYahoo(string text)
        {
            GoToSite("https://search.yahoo.com/search?p=" + text);
        }

        private void GoToSite(string Url)
        {
            if (Url.Contains(".com") || Url.Contains(".net") || Url.Contains(".org") || Url.Contains(".am") || Url.Contains(".ru") || Url.Contains(".us"))
            {
                if (Url.StartsWith("http://"))
                {
                    this.currentBrowser.NavigateWeb(Url);
                }
                else if (Url.StartsWith("https://"))
                {
                    this.currentBrowser.NavigateWeb(Url);
                }
                else if (Url.StartsWith("ftp://"))
                {
                    this.currentBrowser.NavigateWeb(Url);
                }
                else
                {
                    currentBrowser.NavigateWeb("http://" + Url);
                }
            }
            else
            {
                 SearchInWeb(addressTextBox.Text);
            }     
        }
    }
        #endregion
}
