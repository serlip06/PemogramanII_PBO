using P10_1_714220023.controller;
using P10_1_714220023.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220023.view
{
    public partial class FormBarang : Form
    {
        //koneksi 
        Koneksi koneksi = new Koneksi();
        M_Barang m_barang = new M_Barang();
        string id_barang;

        public FormBarang()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void ResetForm()
        {
            nama_barang.Text = "";
            harga.Text = "";

        }
        public void RefreshForm()
        {
            ResetForm();
            Tampil();
        }

        public void Tampil()
        {
            //querydb untuk pembangilan di databasenya
            DataBarang.DataSource = koneksi.ShowData("select * from t_barang ");
            // memunculkan rp di dalam tabel 

            // buat nampilin tabel di data gredviewnya
            DataBarang.Columns[0].HeaderText = "id_barang";
            DataBarang.Columns[1].HeaderText = "nama_barang";
            DataBarang.Columns[2].HeaderText = "Harga ";


        }
        // untuk memunculkan arp pada tampilan form
        private string FormatDigitAngka(int number)
        {
            return string.Format("Rp {0:N0}", number);
        }

        private void DataBarang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int number))
                {
                    e.Value = FormatDigitAngka(number);
                    e.FormattingApplied = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // btn simpan
            if (nama_barang.Text == "" || harga.Text == "")
            {
                // validasi data 
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = nama_barang.Text;
                m_barang.Harga = harga.Text;

                barang.Insert(m_barang);

                ResetForm();
                Tampil();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama_barang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            harga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();


        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            //menampikan methodnya
            Tampil();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            //form btn ubah
            // periksa ulang lagi karena fungsi di btn ubah ini tidak berfungsi bukannya mengubah malah menambah data 
            if (nama_barang.Text == "" || harga.Text == "")
            {
                // validasi data 
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Barang barang = new Barang();
                m_barang.Nama_barang = nama_barang.Text;
                m_barang.Harga = harga.Text;

                barang.Update(m_barang, id_barang);

                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Perhatian!",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);

                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang WHERE id_barang Like '%' ' " + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' ");
        }
    }
}
