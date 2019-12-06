using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace CS_Tabbed_Web_Browser
{
    public partial class ViewSourceForm : Form
    {
        MainWindow MainForm;
        public ViewSourceForm(MainWindow form)
        {
            MainForm = form;
            InitializeComponent();
        }

        private void ViewSourceForm_Load(object sender, EventArgs e)
        {
            ViewSource();
        }

        private void rtbMain_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            MainForm.CallAddTabAndNavigate(e.LinkText);
            MainForm.Focus();
        }

        private void ViewSource()
        {
            try
            {
                string url = MainForm.currentBrowser.Url.ToString();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                rtbMain.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
