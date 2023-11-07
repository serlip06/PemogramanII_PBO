using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            txtNama.Text = txtNama.Text.ToUpper();
           
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, " Textbox huruf tidak boleh kososng !");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }

            else
            {
                if ((txtNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtNama, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, "");
                }
            }
        }

        private void txtHP_Leave(object sender, EventArgs e)
        {
            if (txtHP.Text == "")
            {
                epWarning.SetError(txtHP, " Textbox buruf tidak boleh kososng !");
                epWrong.SetError(txtHP, "");
                epCorrect.SetError(txtHP, "");

            }
            else
            {
                if ((txtHP.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtHP, "Betul!");
                    epWarning.SetError(txtHP, "");
                    epWrong.SetError(txtHP, "");
                }
                else
                {
                    epCorrect.SetError(txtHP, "");
                    epWarning.SetError(txtHP, "");
                    epWrong.SetError(txtHP, "Inputan hanya boleh Angka !");
                }
            }
        }

        private void txtTempat_Leave(object sender, EventArgs e)
        {
            if (txtTempat.Text == "")
            {
                epWarning.SetError(txtTempat, " Textbox huruf tidak boleh kososng !");
                epWrong.SetError(txtTempat, "");
                epCorrect.SetError(txtTempat, "");

            }
            else
            {
                if ((txtTempat.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtTempat, "");
                    epWrong.SetError(txtTempat, "");
                    epCorrect.SetError(txtTempat, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtTempat, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtTempat, "");
                    epCorrect.SetError(txtTempat, "");
                }
            }
        }

        private void txtAgama_Leave(object sender, EventArgs e)
        {
            // ada batasan karakter yang dimasukkan 
            if (txtAgama.Text.Length > 8)
            {
                epWrong.SetError(txtAgama, "Teks terlalu panjang (maksimum 8 karakter)!");
                epWarning.SetError(txtAgama, "");
                epCorrect.SetError(txtAgama, "");
            }
            else if (txtAgama.Text == "")
            {
                epWarning.SetError(txtAgama, "Textbox huruf tidak boleh kosong!");
                epWrong.SetError(txtAgama, "");
                epCorrect.SetError(txtAgama, "");
            }
            else
            {
                if (txtAgama.Text.All(Char.IsLetter))
                {
                    epWarning.SetError(txtAgama, "");
                    epWrong.SetError(txtAgama, "");
                    epCorrect.SetError(txtAgama, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAgama, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtAgama, "");
                    epCorrect.SetError(txtAgama, "");
                }
            }
        }

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epWarning.SetError(txtAlamat, " Textbox huruf tidak boleh kososng !");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "");

            }
            else
            {
                if ((txtAlamat.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtAlamat, "");
                    epWrong.SetError(txtAlamat, "");
                    epCorrect.SetError(txtAlamat, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtAlamat, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtAlamat, "");
                    epCorrect.SetError(txtAlamat, "");
                }
            }
        }

        private void txtSekolah_Leave(object sender, EventArgs e)
        {
            txtSekolah.Text = txtSekolah.Text.ToUpper();
            if (txtSekolah.Text == "")
            {
                epWarning.SetError(txtSekolah, " Textbox huruf tidak boleh kososng !");
                epWrong.SetError(txtSekolah, "");
                epCorrect.SetError(txtSekolah, "");

            }
            else
            {
                if ((txtSekolah.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtSekolah, "");
                    epWrong.SetError(txtSekolah, "");
                    epCorrect.SetError(txtSekolah, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtSekolah, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtSekolah, "");
                    epCorrect.SetError(txtSekolah, "");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Tanggallahir = dtp_tanggal.Value;

            string PilihanMataPelajaran = "";
            string PilihanJadwal = "";

            string Nama = txtNama.Text;
            string Tempat = txtTempat.Text;
            string Agama = txtAgama.Text;
            string NoHP= txtHP.Text;
            string Alamat = txtAlamat.Text;
            string AsalSekolah = txtSekolah.Text;


            if(cb_Matematika.Checked)
            {
                PilihanMataPelajaran += "Matematika";
            }
            if(cb_Biologi.Checked)
            {
                PilihanMataPelajaran += "Biologi";
            }
            if(cb_fisika.Checked)
            {
                PilihanMataPelajaran += "Fisika";
            }
            if (cb_Kimia.Checked)
            {
                PilihanMataPelajaran += "Kimia";
            }
            if (cb_Indonesia.Checked)
            {
                PilihanMataPelajaran += "Indonesia";
            }
            else if (string.IsNullOrEmpty(PilihanMataPelajaran))
            {
                MessageBox.Show("Anda harus memilih Pelajaran", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (rb_SeninRabu.Checked)
            {
                PilihanJadwal += "Senin && Rabu = 14.00 - 17.00";
            }
            if (rb_SelasaKamis.Checked)
            {
                PilihanJadwal += "Selasa && Kamis = 15.00 - 19.00";
            }
            if (rb_JumatSabtu.Checked)
            {
                PilihanJadwal += "Jumat && Sabtu = 09.00 - 12.00";
            }
            else if (string.IsNullOrEmpty(PilihanJadwal))
            {
                MessageBox.Show("Anda harus memilih Jadwal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MessageBox.Show(
                "Nama : " + Nama +
                "\nTempat : " + Tempat+
                "\nTanggal Lahir : " +Tanggallahir.ToString("dd MMMM yyyy") +
                "\nAgama : " + Agama +
                "\nNo HP : " + NoHP +
                "\nAlamat : "+Alamat+
                "\nAsal Sekolah : " + AsalSekolah  + 
                "\nPilihan Mata Pelajaran : "+PilihanMataPelajaran+
                "\nPilihanJadwal : " +PilihanJadwal+
                ""

                );




        }
    }
}
