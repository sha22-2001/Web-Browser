using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void navigatetopage()
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            currentStatus.Text = "Navigation has Started";
            webBrowser1.Navigate(textBox1.Text);
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://github.com/sha22-2001");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigatetopage();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            currentStatus.Text = "Navigation Complete";

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.CurrentProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void refresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
