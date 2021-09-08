using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triple_DES_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Filter = "All File |*";
            OD.FileName = "";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                FileTextBox.Text = OD.FileName;
            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TripleDES tDES = new TripleDES(KeyTextBox.Text);
                tDES.EncryptFile(FileTextBox.Text);
                GC.Collect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TripleDES tDES = new TripleDES(KeyTextBox.Text);
                tDES.DecryptFile(FileTextBox.Text);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
