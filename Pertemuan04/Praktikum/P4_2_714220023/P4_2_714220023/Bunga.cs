using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220023
{
    public class Bunga
    {
        //public string jenis menupakan properti dari "jenis" dengan tipe data string dan 
        //diakses dengan kata kunci public yang artinya dapat diakses di luar kelas
        public string Jenis { get; set; }

        //public string warna menupakan properti dari "Warna" dengan tipe data string dan 
        //diakses dengan kata kunci public yang artinya dapat diakses di luar kelas
        public string Warna { get; set; }
        
        //berikut ini merupakan konstruktor dari keals utama yaitu bungga dengan parameter 1 jenis,
        //dan parameter2 warna
        public Bunga(string jenis, string warna)
        {
            Jenis = jenis;
            Warna = warna;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Jenis: {Jenis}, Warna: {Warna}");
        }//pernyataan yang digunakan untuk mencetak informasi tentang objek "Bunga" ke konsol.
         //Nilai properti "Jenis" dan "Warna" ditampilkan menggunakan interpolasi string.
    }






}
