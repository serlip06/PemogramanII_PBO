using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714220023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string JenisKelamin = cb_jeniskelamin.SelectedItem.ToString();
            DateTime TanggalLahir = dtp_tanggal.Value;

            string PilihanKelas = "";
            string PilihanJadwal = "";

            if(cb_Biola.Checked )
            {
                PilihanKelas += "Biola ";
            }
            if(cb_Gitar.Checked )
            {
                PilihanKelas += "Gitar ";
            }
            if(cb_Saxophone.Checked )
            {
                PilihanKelas += "Saxophone";
            }
            if (cb_Konduktor.Checked )
            {
                PilihanKelas += "Konduktor ";
            }
            if(cb_Piano.Checked )
            {
                PilihanKelas += "Piano ";
            }  
            if(cb_Drum.Checked )
            {
                PilihanKelas += "Drum";
            }
            if(cb_Vokal.Checked)
            {
                PilihanKelas += "Vokal";
            }
            if(cb_Komposer.Checked)
            {
                PilihanKelas += " Komposer";
            }
            else if (string.IsNullOrEmpty(PilihanKelas))
            {
                MessageBox.Show("Anda harus memilih kelas","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }

            if (rb_SeninRabu.Checked)
            {
                PilihanJadwal = "Senin & Rabu 14.00-16.00";
            }
            if (rb_SelasaKamis.Checked)
            {
                PilihanJadwal = "Selasa & Kamis 14.00-16.00";
            }
            if (rb_SabtuMinggu.Checked)
            {
                PilihanJadwal = "Sabtu & Minggu 09.00-11.00";
            }
            if (rb_Minggu.Checked )
            {
                PilihanJadwal = "Minggu, 13.00 - 17.00 ";
            }
            else if (string.IsNullOrEmpty(PilihanJadwal))
            {
                MessageBox.Show("Anda harus memilih Jadwal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(
                "Nama : " + textNama +
                "\nJenis Kelamin: " + JenisKelamin +
                "\nTanggal Lahir: " + TanggalLahir.ToString("dd MMMM yyyy") +
                "\nPilihan Kelas : " + PilihanKelas +
                "\nPilihan Jadwal : " + PilihanJadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
