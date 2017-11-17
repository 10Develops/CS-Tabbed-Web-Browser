using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SHDocVw;
using System.IO;
using System.Text.RegularExpressions;

namespace CS_Tabbed_Web_Browser
{
    public class WebBrowserCore : System.Windows.Forms.WebBrowser
    {
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
            IsWebBrowserContextMenuEnabled = false;
        }

        public void NavigateWeb(string uri)
        {
            Url = new Uri(uri);
        }

        public string ViewSource(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return sr.ReadToEnd();
        }

        public string RemoveHTML(string strHTML)
        {
            return Regex.Replace(strHTML, "<(.|\n)*?>", "");
        }

        protected override void OnNavigating(WebBrowserNavigatingEventArgs e)
        {
            base.OnNavigating(e);
        }

        protected override void OnDocumentCompleted(WebBrowserDocumentCompletedEventArgs e)
        {
            base.OnDocumentCompleted(e);
        }
    }
}
