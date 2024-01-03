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
    public partial class FormTransaksi_Barang : Form
    {
        //koneksi
        Koneksi koneksi = new Koneksi();
        M_transaksi_barang tr_barang = new M_transaksi_barang();
        string id_transaksi;

        public FormTransaksi_Barang()
        {
            InitializeComponent();
        }
        public void ResetForm()
        {
            // untuk mereset formulir
            id_barang.SelectedIndex = -1;
            nama_barang.Text = "";
            harga_barang.Text = "";
            qyt.Text = "";
            total.Text = "";
        }
        public void RefreshForm()
        {
            ResetForm();
            Tampil();
        }

        public void Tampil()
        {
            // mengakses ke database t_transaksi
            DataTransaksiBarang.DataSource = koneksi.ShowData("select * from t_transaksi");
            //menampilkan tabel pada data gred view
            DataTransaksiBarang.Columns[0].HeaderText = "ID";
            DataTransaksiBarang.Columns[1].HeaderText = "ID Barang";
            DataTransaksiBarang.Columns[2].HeaderText = "Nama Barang";
            DataTransaksiBarang.Columns[3].HeaderText = "Harga";
            DataTransaksiBarang.Columns[4].HeaderText = "QTY";
            DataTransaksiBarang.Columns[5].HeaderText = "Total Harga";

            // Menampilkan harga dalam format mata uang Rupiah
            foreach (DataGridViewRow row in DataTransaksiBarang.Rows)
            {
                decimal harga = Convert.ToDecimal(row.Cells[3].Value);
                row.Cells[3].Value = string.Format("RP {0:N2}", harga);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            // untuk mencari data 
            DataTransaksiBarang.DataSource = koneksi.ShowData("SELECT * FROM t_transaksi WHERE id_transaksi Like '%' ' " + tbCariData.Text + "' '%' OR nama_barang LIKE '%' '" + tbCariData.Text + "' '%' ");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //tombol simpan 
            if(id_barang.SelectedIndex ==-1 || nama_barang.Text == "" || harga_barang.Text == "" || qyt.Text == "" || total.Text == "")
            {
                // validasi data '|| disebut or'
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                tr_barang.Id_barang = id_barang.Text;
                tr_barang.Qty = qyt.Text;
                tr_barang.Harga = Convert.ToDecimal(harga_barang.Text); // Konversi harga menjadi decimal
                tr_barang.Total = (Convert.ToDecimal(qyt.Text) * tr_barang.Harga).ToString(); // Hitung total harga

                transaksi.Insert(tr_barang);
                ResetForm();
                Tampil();
            }

        }

        private void DataTransaksiBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = DataTransaksiBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_barang.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            nama_barang.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            harga_barang.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
            qyt.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
            total.Text = DataTransaksiBarang.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void FormTransaksi_Barang_Load(object sender, EventArgs e)
        {
            //menampilkan methodnya
            Tampil();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_barang.SelectedIndex == -1 || nama_barang.Text == "" || harga_barang.Text == "" || qyt.Text == "" || total.Text == "")
            {
                // validasi data '|| disebut or'
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                tr_barang.Id_barang = id_barang.Text;
                tr_barang.Qty = qyt.Text;
                tr_barang.Harga = Convert.ToDecimal(harga_barang.Text); // Konversi harga menjadi decimal
                tr_barang.Total = (Convert.ToDecimal(qyt.Text) * tr_barang.Harga).ToString(); // Hitung total harga

                //tr_barang.Total = total.Text;
                // update pada tombol ubah
                transaksi.Update(tr_barang, id_transaksi);
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
                barang.Delete(id_transaksi);

                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
