using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinesComparer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFile1WithFile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(txtPath1.Text) && File.Exists(txtPath2.Text))
                {
                    if (FilesAreTheSame(txtPath1.Text, txtPath2.Text))
                    {
                        MessageBox.Show("Files are equal!");
                    }
                    else
                    {
                        MessageBox.Show("Files are NOT equal!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong file paths!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool FilesAreTheSame(string filePath1, string filePath2)
        {
            try
            {
                string[] filePath1Array = File.ReadAllLines(filePath1);
                string[] filePath2Array = File.ReadAllLines(filePath2);

                filePath1Array = filePath1Array.OrderBy(x => x).ToArray();
                filePath2Array = filePath2Array.OrderBy(x => x).ToArray();

                return filePath1Array.SequenceEqual(filePath2Array);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnFile1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    txtPath1.Text = file;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnFile2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    txtPath2.Text = file;
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
