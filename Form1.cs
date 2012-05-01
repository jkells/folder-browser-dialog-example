using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolderBrowserExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButtonClick(object sender, EventArgs e)
        {
            var dlg1 = new Ionic.Utils.FolderBrowserDialogEx();
            dlg1.Description = "Select a file or folder";
            dlg1.ShowNewFolderButton = true;
            dlg1.ShowEditBox = true;
            dlg1.ShowBothFilesAndFolders = true;
            dlg1.ShowFullPathInEditBox = true;
            dlg1.RootFolder = System.Environment.SpecialFolder.MyComputer;

            // Show the FolderBrowserDialog.
            DialogResult result = dlg1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = dlg1.SelectedPath;
                if(Directory.Exists(dlg1.SelectedPath))
                {
                    MessageBox.Show("Directory selected: " + dlg1.SelectedPath);
                }
                else{
                    MessageBox.Show("File selected: " + dlg1.SelectedPath);
                }
            }
        }
    }
}
