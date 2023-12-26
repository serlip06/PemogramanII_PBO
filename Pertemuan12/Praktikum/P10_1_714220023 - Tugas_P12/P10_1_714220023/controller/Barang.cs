using P10_1_714220023.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220023.controller
{
    
    class Barang
    {
        Koneksi koneksi = new Koneksi();

        //Method insert
        public bool Insert(M_Barang barang)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_barang (nama_barang, harga) VALUES('" + barang.Nama_barang + "', '" + barang.Harga + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
        //Method update
        public bool Update(M_Barang barang, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_barang (nama_barang, harga) VALUES ('" + barang.Nama_barang + "','" + barang.Harga + "')");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
        //Method delete
        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_barang WHERE id_barang='"
               + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            return status;
        }
    }

    //internal class Barang
    //{
    // }
}
