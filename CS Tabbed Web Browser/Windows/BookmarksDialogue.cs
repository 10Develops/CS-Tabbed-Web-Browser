using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Tabbed_Web_Browser
{
    public partial class BookmarksDialogue : Form
    {
        MainWindow MainForm;
        public BookmarksDialogue(MainWindow form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void HistoryDialogue_Load(object sender, EventArgs e)
        {
            foreach (string item in Properties.Settings.Default.Bookmarks)
            {
                lbBookmarks.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbBookmarks.Items.Clear();
            Properties.Settings.Default.Bookmarks.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Bookmarks.Remove(lbBookmarks.SelectedItem.ToString());
            lbBookmarks.Items.Remove(lbBookmarks.SelectedItem);
        }

        private void lbBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBookmarks.SelectedItems.Count == 1)
            {
                cs.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                cs.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        private void lbBookmarks_DoubleClick(object sender, EventArgs e)
        {
            if (lbBookmarks.SelectedItems.Count == 1)
            {
                MainForm.Focus();
                MainForm.CallAddTabAndNavigate(lbBookmarks.SelectedItem.ToString());
            }
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            btnRemove.PerformClick();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbBookmarks.SelectedItem.ToString());
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            MainForm.Focus();
            MainForm.CallNavigate(lbBookmarks.SelectedItem.ToString());
        }

        private void tsmiOpenInNewTab_Click(object sender, EventArgs e)
        {
            lbBookmarks_DoubleClick(sender, e);
        }
    }
}
