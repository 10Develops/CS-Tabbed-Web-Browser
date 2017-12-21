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
    public partial class HistoryDialogue : Form
    {
        MainWindow MainForm;
        public HistoryDialogue(MainWindow form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void HistoryDialogue_Load(object sender, EventArgs e)
        {
                foreach (string item in Properties.Settings.Default.History)
                {
                        lbHistory.Items.Add(item);
                }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();
            Properties.Settings.Default.History.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
                Properties.Settings.Default.History.Remove(lbHistory.SelectedItem.ToString());
                lbHistory.Items.Remove(lbHistory.SelectedItem);
        }

        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHistory.SelectedItems.Count == 1)
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

        private void lbHistory_DoubleClick(object sender, EventArgs e)
        {
            if (lbHistory.SelectedItems.Count == 1)
            {
                MainForm.Focus();
                MainForm.CallAddTabAndNavigate(lbHistory.SelectedItem.ToString());
            }
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            btnRemove.PerformClick();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbHistory.SelectedItem.ToString());
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            MainForm.Focus();
            MainForm.CallNavigate(lbHistory.SelectedItem.ToString());
        }

        private void tsmiOpenInNewTab_Click(object sender, EventArgs e)
        {
            lbHistory_DoubleClick(sender, e);
        }
    }
}
