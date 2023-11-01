using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714220023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if(txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, " Textbox buruf tidak boleh kososng !");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");

            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
            
        }

        private void textAngka_Leave(object sender, EventArgs e)
        {
            if (textAngka.Text == "")
            {
                epWarning.SetError(textAngka, " Textbox buruf tidak boleh kososng !");
                epWrong.SetError(textAngka, "");
                epCorrect.SetError(textAngka, "");

            }
            else
            {
                if ((textAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(textAngka, "Betul!");
                    epWarning.SetError(textAngka, "");
                    epWrong.SetError(textAngka, "");
                }
                else
                {
                    epCorrect.SetError(textAngka, "");
                    epWarning.SetError(textAngka, "");
                    epWrong.SetError(textAngka, "Inputan hanya boleh Angka !");
                }
            }
           
        }

        private void textAngka_Leave_1(object sender, EventArgs e)
        {
            
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                epWarning.SetError(textEmail, " Textbox buruf tidak boleh kososng !");
                epWrong.SetError(textEmail, "");
                epCorrect.SetError(textEmail, "");

            }
            else
            {
                if (Regex.IsMatch(textEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(textEmail, "");
                    epWrong.SetError(textEmail, "");
                    epCorrect.SetError(textEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(textEmail, "Format email salah ! \nContoh : a@b.c");
                    epWarning.SetError(textEmail, "");
                    epCorrect.SetError(textEmail, "");

                }
            }
            
        }

        private void textAngka1_Leave(object sender, EventArgs e)
        {
            if (textAngka1.Text == "")
            {
                epWarning.SetError(textAngka1, " Textbox buruf tidak boleh kososng !");
                epWrong.SetError(textAngka1, "");
                epCorrect.SetError(textAngka1, "");

            }
            else
            {
                if (int.TryParse(textAngka1.Text, out int angka1) && int.TryParse(textAngka2.Text, out int angka2))
                    if (angka1 > angka2)
                    {
                        epCorrect.SetError(textAngka1, "Betul!");
                        epWarning.SetError(textAngka1, "");
                        epWrong.SetError(textAngka1, "");
                    }
                    else
                    {
                        epCorrect.SetError(textAngka1, "");
                        epWarning.SetError(textAngka1, "");
                        epWrong.SetError(textAngka1, "Angka1 harus lebih besar dari Angka2.");
                    }
                else
                {
                    epCorrect.SetError(textAngka1, "");
                    epWarning.SetError(textAngka1, "");
                    epWrong.SetError(textAngka1, "Inputan hanya boleh angka!");
                }
            }
           
        }

        private void textAngka2_Leave(object sender, EventArgs e)
        {
            if (textAngka2.Text == "")
            {
                epWarning.SetError(textAngka2, " Textbox buruf tidak boleh kososng !");
                epWrong.SetError(textAngka2, "");
                epCorrect.SetError(textAngka2, "");

            }
            else
            {
                if (int.TryParse(textAngka1.Text, out int angka1) && int.TryParse(textAngka2.Text, out int angka2))
                {
                    if (angka1 > angka2)
                    {
                        epCorrect.SetError(textAngka2, "Betul!");
                        epWarning.SetError(textAngka2, "");
                        epWrong.SetError(textAngka2, "");
                    }
                    else
                    {
                        epCorrect.SetError(textAngka2, "");
                        epWarning.SetError(textAngka2, "");
                        epWrong.SetError(textAngka2, "Angka2 harus lebih kecil dari Angka1.");
                    }
                }
                else
                {
                    epCorrect.SetError(textAngka2, "");
                    epWarning.SetError(textAngka2, "");
                    epWrong.SetError(textAngka2, "Inputan hanya boleh angka!");
                }
            }
           

        }
    }
}
