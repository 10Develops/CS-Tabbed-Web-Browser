using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using MSHTML;
namespace CS_Tabbed_Web_Browser
{
    public class WebBrowserCore : WebBrowser
    {
        SHDocVw.WebBrowser xBrowser;
        public WebBrowserCore()
        {
            ScriptErrorsSuppressed = true;
            if (Properties.Settings.Default.UseProxy == true)
            {
                WinInetInterop.RefreshIESettings(Properties.Settings.Default.Proxy);
            }
            else
            {
                WinInetInterop.RefreshIESettings(":");
            }
            UrlMonInterop.ChangeUserAgent("Mozilla/5.0 (Windows NT 10.0; Trident/7.0; rv:11.0) like Gecko");
            IsWebBrowserContextMenuEnabled = false;
            xBrowser = (SHDocVw.WebBrowser)ActiveXInstance;

        }

        public void NavigateWeb(string uri)
        {
            xBrowser.Navigate(uri);
        }
    }
}
