using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angka pertama :");
            float angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan angka kedua: ");
            float angka2 = Convert.ToInt32(Console.ReadLine());

           

           // int angka1 =;
            //int angka2 =;
            float Penjumlahan;
            float pengurangan;
            float perkalian;
            float pembagian;

            Penjumlahan = angka1 + angka2;
            pengurangan = angka1 - angka2;
            perkalian = angka1 * angka2;
            pembagian = angka1 / angka2;

           
            //Console.Write("SILAHKAN MASUKSAN ANGKA");
            //string angka = Console.ReadLine();
            //Console.WriteLine(" " + angka);
            
            
            //Console.WriteLine(" angka pertama =" + angka1);
            //Console.WriteLine("angka kedua = " + angka2);
            Console.WriteLine("{0} + {1} = {2} ", angka1, angka2, Penjumlahan);
            Console.WriteLine("{0} - {1} = {2} ", angka1, angka2, pengurangan);
            Console.WriteLine("{0} * {1} = {2} ", angka1, angka2, perkalian);
            Console.WriteLine("{0} / {1} = {2} ", angka1, angka2, pembagian);

            

        }
    }
}
