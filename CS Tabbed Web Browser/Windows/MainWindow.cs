using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using mshtml;
using System.IO;

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
        public WebBrowserCore currentBrowser;

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
            NewTab();

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

            showProgressBarTSMI.Checked = Properties.Settings.Default.ShowProgressBar;
            pnlProgressBar.Visible = Properties.Settings.Default.ShowProgressBar;
            showStatusBarTSMI.Checked = Properties.Settings.Default.ShowStatusBar;
            pnlStatus.Visible = Properties.Settings.Default.ShowStatusBar;
            homeButton.Visible = Properties.Settings.Default.ShowHomePage;

            foreach (string item in Properties.Settings.Default.History)
            {
                addressTextBox.AutoCompleteCustomSource.Add(item);
            }
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
            if (e.Control && e.KeyCode == Keys.O)
            {
                addressTextBox.ShortcutsEnabled = true;
                currentBrowser.WebBrowserShortcutsEnabled = true;
                e.SuppressKeyPress = true;
                addressTextBox.Focus();
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

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;

            addressTextBox.AutoCompleteCustomSource.Clear();

            if (WindowState == FormWindowState.Normal)
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

        private void showProgressBarTSMI_Click(object sender, EventArgs e)
        {
            showProgressBarTSMI.Checked = !showProgressBarTSMI.Checked;
            pnlProgressBar.Visible = showProgressBarTSMI.Checked;
            Properties.Settings.Default.ShowProgressBar = showProgressBarTSMI.Checked;
        }

        private void showStatusBarTSMI_Click(object sender, EventArgs e)
        {
            showStatusBarTSMI.Checked = !showStatusBarTSMI.Checked;
            pnlStatus.Visible = showStatusBarTSMI.Checked;
            Properties.Settings.Default.ShowStatusBar = showStatusBarTSMI.Checked;
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

        private void newTabTSMI_Click(object sender, EventArgs e)
        {
            newTabButton.PerformClick();
        }

        private void closeTabTSMI_Click(object sender, EventArgs e)
        {
            closeTabButton.PerformClick();
        }

        private void showCertTSMI_Click(object sender, EventArgs e)
        {
            try
            { 
                //Do webrequest to get info on secure site
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(currentBrowser.Url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Close();

                //retrieve the ssl cert and assign it to an X509Certificate object
                X509Certificate cert = request.ServicePoint.Certificate;
                //convert the X509Certificate to an X509Certificate2 object by passing it into the constructor
                X509Certificate2 cert2 = new X509Certificate2(cert);

                //display the cert dialog box
                X509Certificate2UI.DisplayCertificate(cert2);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Certificate is not found.", "Error", MessageBoxButtons.OK);
            }
        }
        
        private void bookmarkThisPageTSMI_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Bookmarks.Add(currentBrowser.Url.ToString());
        }

        private void allBookmarksTSMI_Click(object sender, EventArgs e)
        {
            BookmarksDialogue bookmarksDialogs = new BookmarksDialogue(this);
            bookmarksDialogs.Show();
        }

        private void ClearBookmarksTSMI_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Bookmarks.Clear();
            BookmarksTSMI.DropDownItems.Clear();
        }

        private void BookmarksTSMI_DropDownOpening(object sender, EventArgs e)
        {
            BookmarksTSMI.DropDownItems.Clear();

            foreach (string item in Properties.Settings.Default.Bookmarks)
            {
                if (BookmarksTSMI.DropDownItems.Count < 10)
                {
                    ToolStripItem bookmarkItem = new ToolStripMenuItem();
                    bookmarkItem.Tag = item;
                    bookmarkItem.Text = item;
                    bookmarkItem.Click += bookmarkItem_Click;
                    BookmarksTSMI.DropDownItems.Add(bookmarkItem);
                }
            }

            BookmarksTSMI.DropDownItems.Add(allBookmarksTSMI);
        }

        private void bookmarkItem_Click(object sender, EventArgs e)
        {
            ToolStripItem itemSender = sender as ToolStripItem;
            CallAddTabAndNavigate(itemSender.Text);
        }

        #endregion

        #region Toolbar Event Handlers

        private void backButton_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Stop();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoHome();
        }

        private void newTabButton_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            this.tabs.RemoveCurrentTab();
        }

        #endregion

        #region Drop Down Manu Event Handlers

        private void historyTSMI_Click(object sender, EventArgs e)
        {
            HistoryDialogue history = new HistoryDialogue(this);
            history.Show();
        }

        private void consoleTSMI_Click(object sender, EventArgs e)
        {
            ConsoleForm console = new ConsoleForm(this);
            console.Show();
        }

        private void viewSourceDropDown_Click(object sender, EventArgs e)
        {
            ViewSourceForm viewSource = new ViewSourceForm(this);
            viewSource.Show();
        }

        private void updatesTSMI_Click(object sender, EventArgs e)
        {
            UpdatesForm updatesForm = new UpdatesForm();
            updatesForm.Show();
        }

        private void tsmiOptions_Click(object sender, EventArgs e)
        {
            using (OptionsDialogue dialogue = new OptionsDialogue(this.currentBrowser.Url.ToString()))
            {
                dialogue.ShowDialog();
            }
        }

        private void aboutTSMI_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        #endregion

        #region Context Manu Event Handlers

        private void backTSMI_Click(object sender, EventArgs e)
        {
            backButton.PerformClick();
        }

        private void forwardTSMI_Click(object sender, EventArgs e)
        {
            forwardButton.PerformClick();
        }

        private void refreshTSMI_Click(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        private void selectAllTSMI_Click(object sender, EventArgs e)
        {
            currentBrowser.Document.ExecCommand("SelectAll", true, null);
        }

        private void viewSourceTSMI_Click(object sender, EventArgs e)
        {
            viewSourceDropDown.PerformClick();
        }

        private void copyTSMI_Click(object sender, EventArgs e)
        {
            currentBrowser.Document.ExecCommand("Copy", false, null);
        }

        private void searchTSMI_Click(object sender, EventArgs e)
        {
            SearchInWebNewTab(WordToSearch);
        }
        #endregion

        #region Tab Control Event Handlers
        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current browser.
            this.currentBrowser = this.tabs.SelectedWebBrowser;
            this.DisplayPageTitle();

            CheckIfCanGoBack();
            CheckIfCanGoForward();

            // Enable the Close Tab command if and only if there is more than one tab.
            if (this.tabs.TabCount == 2)
            {
                this.closeTabButton.Enabled = false;
                closeTabTSMI.Enabled = false;
            }
            else
            {
                this.closeTabButton.Enabled = true;
                closeTabTSMI.Enabled = true;
            }

            Uri url = this.currentBrowser.Url;

            if (url == null)
            {
                // There is no current address.
                this.addressTextBox.Text = string.Empty;

                // The user cannot refresh a page that doesn't exist.
                this.refreshButton.Enabled = false;
                refreshTSMI.Enabled = false;
            }
            else
            {
                // Display the current page address in the address bar.
                this.addressTextBox.Text = url.ToString();

                // Allow the user to refresh the current page.
                this.refreshButton.Enabled = true;
                refreshTSMI.Enabled = true;

                if (url.OriginalString.StartsWith("https://"))
                {
                    showCertTSMI.Visible = true;
                }
                else
                {
                    showCertTSMI.Visible = false;
                }
            }
        }

        private void tabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabs.TabCount - 1)    
            e.Cancel = true;
        }

        private void tabs_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabs.TabCount - 1;
            if (this.tabs.GetTabRect(lastIndex).Contains(e.Location))
            {
                NewTab();
            }
        }
        #endregion

        #region Web Browser Event Handlers

        private void currentBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            // Display the current page's status text in the status bar.
            if (Properties.Settings.Default.EnableDynamicStatusBar == true)
            {
                if (currentBrowser.StatusText == "")
                {
                    pnlStatus.Visible = false;
                }
                else
                {
                    pnlStatus.Visible = true;
                    this.lblStatus.Text = this.currentBrowser.StatusText;
                }
            }
            else
            {
                this.lblStatus.Text = this.currentBrowser.StatusText;
            }
        }

        private void currentBrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            CheckIfCanGoBack();
        }

        private void currentBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            CheckIfCanGoForward();
        }

        private void currentBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.DisplayPageTitle();
        }

        private void currentBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Properties.Settings.Default.History.Add(currentBrowser.Url.ToString());
            this.addressTextBox.Text = this.currentBrowser.Url.ToString();
            typeTSMI.Text = currentBrowser.DocumentType;
            pnlProgress.Width = 0;

            this.refreshButton.Visible = true;
            this.refreshButton.Enabled = true;
            stopButton.Visible = false;
            stopButton.Enabled = false;
            refreshTSMI.Enabled = true;

            if (e.Url.OriginalString.StartsWith("https://"))
            {
                showCertTSMI.Visible = true;
            }
            else
            {
                showCertTSMI.Visible = false;
            }
        }

        private void currentBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if(Properties.Settings.Default.EnableDynamicProgressBar == true)
            {
                if (e.CurrentProgress == 0)
                {
                    pnlProgressBar.Visible = false;
                }
                else
                {
                    pnlProgressBar.Visible = true;
                    pnlProgress.Width = (int)e.CurrentProgress;
                }
            }
            else
            {
                pnlProgress.Width = (int)e.CurrentProgress;
            }
        }

        private void currentBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            try
            {
                HtmlElement link = currentBrowser.Document.ActiveElement;
                Uri urlNavigated = new Uri(link.GetAttribute("href"));

                NewTab();

                currentBrowser.NavigateWeb(urlNavigated.ToString());
            }
                catch (Exception){ }
                e.Cancel = true;
        }

        private void currentBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            refreshButton.Visible = false;
            refreshButton.Enabled = false;
            stopButton.Visible = true;
            stopButton.Enabled = true;
        }

        string WordToSearch;
        private void Document_ContextMenuShowing(object sender, HtmlElementEventArgs e)
        {
            IHTMLDocument2 htmlDocument = currentBrowser.Document.DomDocument as IHTMLDocument2;
            IHTMLSelectionObject currentSelection = htmlDocument.selection;
            if (currentSelection.type == "Text")
            {
                IHTMLTxtRange range = currentSelection.createRange() as IHTMLTxtRange;
                if (range != null || range.text.Trim() != "")
                {
                    currentBrowser.ContextMenuStrip = cmsText;
                    if (range.text.Length <= 30)
                    {
                        searchTSMI.Text = string.Format("Search \"{0}\" in the Web", range.text);
                    }
                    else
                    {
                        searchTSMI.Text = string.Format("Search \"{0}\" in the Web", range.text.Substring(0, 30));
                    }
                    WordToSearch = range.text;
                }
            }
            else
            {
                currentBrowser.ContextMenuStrip = cmsGeneral;
            }
        }
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
            if (Properties.Settings.Default.DefaultSearchEngine == 0)
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

        private void SearchInWebNewTab(string text)
        {
            NewTab();

            if (Properties.Settings.Default.DefaultSearchEngine == 0)
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
            if (Url.Contains(".com") || Url.Contains(".net") || Url.Contains(".org") || Url.Contains(".am") || Url.Contains(".ru") || Url.Contains(".us") || Url.Contains(".edu"))
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

        private void NewTab()
        {
            // Add the default Tab
            tabs.AddTab();
            this.currentBrowser = this.tabs.SelectedWebBrowser;
            this.currentBrowser.StatusTextChanged += new EventHandler(currentBrowser_StatusTextChanged);
            this.currentBrowser.DocumentTitleChanged += new EventHandler(currentBrowser_DocumentTitleChanged);
            this.currentBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(currentBrowser_DocumentCompleted);
            this.currentBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(currentBrowser_ProgressChanged);
            currentBrowser.NewWindow += new CancelEventHandler(currentBrowser_NewWindow);
            currentBrowser.Navigating += new WebBrowserNavigatingEventHandler(currentBrowser_Navigating);
            currentBrowser.Document.ContextMenuShowing += new HtmlElementEventHandler(Document_ContextMenuShowing);
            currentBrowser.CanGoBackChanged += new EventHandler(currentBrowser_CanGoBackChanged);
            currentBrowser.CanGoForwardChanged += new EventHandler(currentBrowser_CanGoForwardChanged);
        }

        private void CheckIfCanGoBack()
        {
            bool canGoBack = this.currentBrowser.CanGoBack;

            this.backButton.Enabled = canGoBack;
            backTSMI.Enabled = canGoBack;
        }

        private void CheckIfCanGoForward()
        {
            bool canGoForward = this.currentBrowser.CanGoForward;

            this.forwardButton.Enabled = canGoForward;
            forwardTSMI.Enabled = canGoForward;
        }

        public void CallNavigate(string Site)
        {
            currentBrowser.NavigateWeb(Site);
        }

        public void CallAddTabAndNavigate(string Site)
        {
            NewTab();
            currentBrowser.NavigateWeb(Site);
        }
    }
        #endregion
}