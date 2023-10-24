using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220023
{
    public class Mawar : Bunga
    {
        public Mawar(string warna) : base("Mawar", warna)
        {
        }
        //berikut adalah perintah dari polymorfisme dimana objek dari class turunan ("Mawar")
        //menggantikan implementasi metode yang ada dalam class dasar ("Bunga") 
        public override void DisplayInfo()
        {
            Console.WriteLine($"Ini adalah Mawar {Warna}");
        }
    }

}
