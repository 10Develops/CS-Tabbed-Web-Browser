using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
namespace CS_Tabbed_Web_Browser
{
    public partial class ConsoleForm : Form
    {
        MainWindow MainForm;
        public ConsoleForm(MainWindow form)
        {
            MainForm = form;
            InitializeComponent();
        }

        private void rtbMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainForm.Focus();
                InjectJavaScript();
            }
        }
        private void InjectJavaScript()
        {
            HtmlElement head = MainForm.currentBrowser.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = MainForm.currentBrowser.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            element.text = rtbMain.Text;
            head.AppendChild(scriptEl);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            InjectJavaScript();
        }
    }
}
