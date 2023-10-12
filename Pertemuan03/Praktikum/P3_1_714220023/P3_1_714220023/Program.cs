using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714220023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do//Perulangan mengunakan do while 
            {
                Console.Clear();

                Console.Write("MENENTUKAN INDEKS PRESTASI MAHASISWA\n--------------------------------------");
                Console.Write("\nMasukkan Nama Mahasiswa: ");// menginput nama mahasiswa 

                String nama = Console.ReadLine(); 

                Console.WriteLine(" Masukkan Nilai : ");

                int nilai =  Convert.ToInt16(Console.ReadLine());// code ini berfungsi untuk memasukan angka yang kemudian
                //dikonversi kedalam teks agar dapat dibaca

                String[] grade = { "A", "B", "C" , "D"};

                if (nilai >= 85) //jika memasukkan nilai lebih dari 85 maka grade yang keluar adlah huruf A
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 &&  nilai < 85)//jika memasukkan nilai lebih dari 70 dan kurang
                                                    //dari 85maka grade yg keluar adalah b
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[1]);
                }
                else if(nilai >= 60 && nilai < 70)//jika memasukkan nilai lebih dari 60 dan kurang
                                                  //dari 70maka grade yg keluar adalah c
                                                  // jika angka yang di masukkan kurang dari 60 maka 
                                                  //grade yg keluar adalah D
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.WriteLine("\nMasukkan indeks yang ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("indeks prestasi {0} adalah", nama);

                prestasi(indeks);

                Console.WriteLine("\nIngin mengulang kembali (Y/T)? ");
            }

            while (Console.ReadLine() == "Y");//perogram akan memulai kembali dari awal jika menuliskan Y 
        }

        private static void prestasi(char indeks)// perintah untuk grade  dari nilai yang dimasukkan  
        {
            switch(indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("baik");
                    break;
                case 'C':
                    Console.WriteLine("cukup");
                    break;
                case 'D':
                    Console.WriteLine("buruk");
                    break;
                default:
                    Console.WriteLine("invalid indeks prestasi");
                    break;
            }
        }
    }
}
