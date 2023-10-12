using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220023
{
    internal class Program
    {
      static void Main(string[] args)
        {
            
            Console.WriteLine("\nMasukkan Nilai N :");// berfungsi untuk memasukkan nilai N
            int nilai = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(" ANAK AYAM TURUN " + nilai);

            int ayam = 10; // jumlah awal anak ayam

            for (int i = ayam ; i >= 0; i--)//kondisi perulangan for pada kondisi yang akan terus berkurang 
            {
                if (i > 1)//jika indeks i lebih besar dari 1 maka akan memunculkan hasil yang terus berkurang
                {
                    Console.WriteLine("Anak ayam turun" +i+ ",mati satu tinggallah " + (i-1));
                }
                else if (i ==1) 
                {
                    Console.WriteLine("Anak ayam turun " + i + ",mati satu tinggallah induknya ");
                }
               
            }
            


        }
    }
}
