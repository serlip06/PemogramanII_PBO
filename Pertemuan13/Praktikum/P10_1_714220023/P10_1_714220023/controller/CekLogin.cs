﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_1_714220023.controller
{
    //internal class CekLogin
    //{
    //}

    class Ceklogin
    {
        Koneksi koneksi = new Koneksi();

        public bool Cek_login(string username, string password)
        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM t_user WHERE username= '" + username + "' AND password= '" + password + "'");
                if (reader.Read()) 
                {
                    koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return false;
        }

    }
}
