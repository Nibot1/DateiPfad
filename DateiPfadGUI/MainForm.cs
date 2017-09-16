using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateiPfadGUI
{
    public partial class MainForm : Form
    {
        String path;
        String initDir = "%HOMEPATH%";
        public MainForm(String[] args)
        {
            InitializeComponent();
            if(args.Length != 0)
            {
                path = args[0];
                pathLabel.Text = path;
                copyButton.Enabled = true;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(path);
        }

        private void choseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = initDir;

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                path = openDialog.FileName;
                pathLabel.Text = path;
                copyButton.Enabled = true;
            }
        }

        private void pathLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
