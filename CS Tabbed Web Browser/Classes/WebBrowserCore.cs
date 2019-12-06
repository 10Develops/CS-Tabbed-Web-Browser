using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using mshtml;
using System.Drawing;
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

        public Image Favicon()
        {
            try
            { 
                if(Url.HostNameType == UriHostNameType.Dns)
                {
                    string icon = "http://" + Url.Host + "/favicon.ico";
                    WebRequest request = WebRequest.Create(icon);
                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    return Image.FromStream(stream);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public void NavigateWeb(string uri)
        {
            xBrowser.Navigate(uri);
        }
    }
}
