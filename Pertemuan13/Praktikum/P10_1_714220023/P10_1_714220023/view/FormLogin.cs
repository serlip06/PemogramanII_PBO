using P10_1_714220023.controller;
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
    public partial class FormLogin : Form
    {

        Ceklogin login = new Ceklogin();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong !!!");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                bool status = login.Cek_login(username, password);
                if(status)
                {
                    MessageBox.Show("Login Berhasil", "Berhasil");
                    ParentForm pfrom = new ParentForm();
                    this.Hide();
                    pfrom.Show();
                }
                else
                {
                    MessageBox.Show("Gagal Login", "Gagal");
                }
            }
        }
    }
}
