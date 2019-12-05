using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;
namespace CS_Tabbed_Web_Browser
{
    /// <summary>
    /// A <b>TabControl</b> designed to display <see cref="WebBrowserTabPage" /> objects.
    /// </summary>
    public class WebBrowserTabControl : TabControl
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        #region Properties

        public WebBrowserTabControl()
        {
            DrawMode = TabDrawMode.Normal;
        }

        /// <summary>
        /// Gets the currently selected tab page.
        /// </summary>
        /// <value>
        /// The <see cref="WebBrowserTabPage" /> that is currently selected.
        /// </value>
        public WebBrowserTabPage SelectedWebBrowserTagPage
        {
            get
            {
                return (WebBrowserTabPage)this.SelectedTab;
            }
        }

        /// <summary>
        /// Gets the currently selected web browser.
        /// </summary>
        /// <value>
        /// The <b>WebBrowser</b> control on the currently selected tab page.
        /// </value>
        public WebBrowserCore SelectedWebBrowser
        {
            get
            {
                return this.SelectedWebBrowserTagPage.Browser;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a new, empty page to the tab control.
        /// </summary>
        /// <returns> 
        /// The <see cref="WebBrowserTabPage" /> that was added.
        /// </returns>
        public WebBrowserTabPage AddTab()
        {
            WebBrowserTabPage tab = new WebBrowserTabPage();
            if (TabCount == 0)
            {
                TabPages.Insert(TabCount, tab);
            }
            else
            {
                TabPages.Insert(TabCount - 1, tab);
            }
            this.SelectedTab = tab;
            return tab;
        }

        /// <summary>
        /// Adds a new page to the tab control and navigates to the specified address.
        /// </summary>
        /// <param name="address">
        /// The address of the page to display in the new tab.
        /// </param>
        /// <returns>
        /// The <see cref="WebBrowserTabPage" /> that was added.
        /// </returns>
        public WebBrowserTabPage AddTab(string address)
        {
            WebBrowserTabPage tab = this.AddTab();
            tab.Browser.Navigate(address);
            return tab;
        }

        /// <summary>
        /// Removes the currently selected tab from the tab control.
        /// </summary>
        /// <returns>
        /// <b>True</b> if the current tab was removed; otherwise, <b>False</b>.
        /// </returns>
        /// <remarks>
        /// There must always be at least one tab so the last tab cannot be removed.
        /// </remarks>
        public bool RemoveCurrentTab()
        {
            bool canRemove = this.TabCount > 2;

            if (canRemove)
            {
                WebBrowserTabPage tab = this.SelectedWebBrowserTagPage;
                this.TabPages.Remove(tab);
                tab.Dispose();
            }

            return canRemove;
        }

        #endregion

        protected override void OnHandleCreated(EventArgs e)
        {
            SendMessage(Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)30);
            base.OnHandleCreated(e);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 10, e.Bounds.Top + 6);
            e.Graphics.DrawString(this.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top + 6);
            e.DrawFocusRectangle();

        }
    }
}