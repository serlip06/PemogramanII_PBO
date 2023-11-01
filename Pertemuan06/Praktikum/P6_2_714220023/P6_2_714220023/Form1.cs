using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_2_714220023
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //show the openFileDialog dan check DialogResult
                DialogResult userRespon = openFileDialog1.ShowDialog();
                if(userRespon == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName.ToString();
                    MessageBox.Show("you successfully opened:  '" + filePath + "'", "Sucess",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("you canceled the open file operation . ", "Warning ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
