using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(345, 238);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if(string.IsNullOrWhiteSpace(txtNama.Text))
            {
                errorMessage += "nama belum diisi \n";
            }
            if(string.IsNullOrWhiteSpace(txtProdi.Text))
            {
                errorMessage += "Prodi belum diisi \n";
            }else if(!Regex.IsMatch(txtProdi.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus Berformat [Strata] - [Prodi]";
            }

            if(string.IsNullOrWhiteSpace(txtKelas.Text))
            {
                errorMessage += "Kelas belum diisi \n";
            }

            if(string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap ",
                    "Informasi data submit ",
                    MessageBoxButtons.OK,MessageBoxIcon.Information
                    );

                this.Size = new Size(345, 483);
            }

            else
            {
                MessageBox.Show(
                    errorMessage,
                    "Informasi data submit ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }

        private void rbSenin_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSenin.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = true;
                cbTraveling.Enabled = false; cbTraveling.Checked = false;
                cbTidur.Enabled = false; cbTidur.Checked = false;

            }
        }

        private void rbMinggu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMinggu.Checked)
            {
                cbKuliah.Enabled = false; cbKuliah.Checked = false;
                cbTraveling.Enabled = true; cbTraveling.Checked = true;
                cbTidur.Enabled = false; cbTidur.Checked = false;

            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //txtNama.Text = null;
           // txtProdi.Text = null;
            //txtKelas.Text = null;

            foreach(Control control in Controls)
            {
                if(control is TextBox)((TextBox)control).Text = String.Empty;
                else if (control is RadioButton)((RadioButton)control).Checked = false;
                else if (control is CheckBox)((CheckBox)control).Checked = false;
                //penggunaan combo box
                else if ( control is ComboBox)((ComboBox)control).SelectedIndex = - 1;

            }
            this.Size = new Size(345, 283);

           //tugas bikin perintah printnya baru di push 
           // buat uts kalo  tar masukin data terus data salah jangan sampe keluar informasi di jendela/ buat itu ga bisa nampilin informasinya 
           //
        }
    }
}
