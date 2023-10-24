using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bunga bunga = new Bunga("Bunga Biasa", "Kuning");
            Mawar mawarMerah = new Mawar("Merah");

            Bunga mawarPolimorfik = mawarMerah;

            bunga.DisplayInfo();
            mawarMerah.DisplayInfo();
            mawarPolimorfik.DisplayInfo();
        }
    }
}
