using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                
                do
                {
                    Console.WriteLine("MENU PERSEGI PANJANG :");//menampilkan tampilan menu pada output
                    Console.WriteLine("1. Hitung Luas ");// menampilkan pilihan luas
                    Console.WriteLine("2. Hitung keliling ");// menampilkan pilihan keliling 
                    Console.WriteLine("Menu pilihan :");
                    string input = Console.ReadLine();// memasukkan pilihan menu 1 atau menu 2 

                    if (input == "1")// jika memilih mengimput menu pertama
                    {
                        Console.WriteLine("Masukkan panjang : ");//memasukkan angka pada rumus 
                        int panjang = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Masukkan lebar : ");// memasukkan angka pada rumus 
                        int lebar = Convert.ToInt16(Console.ReadLine());

                        int luas = panjang * lebar;//rumus ini sebelumnya telah di deklarasikan terlebih dahulu
                        Console.WriteLine($"Luas Persegi Panjang : {luas}");
                    }
                    else if (input == "2")// memilih menu kedua 
                    {
                        Console.WriteLine(" Masukkan panjang : ");
                        int panjang = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Masukkan lebar :");
                        int lebar = Convert.ToInt16(Console.ReadLine());

                        int keliling = 2 * (panjang + lebar);
                        Console.WriteLine($" Keliling Persegi Panjang :{keliling} ");
                    }
                    else
                    {
                        Console.WriteLine("MENU TIDAK TERSEDIA");
                    }

                    Console.WriteLine("Inggin mengulang (Y/T) : ");
                }
                while (Console.ReadLine() == "Y");// Jika menginputkan huruf Y maka program akan mengulang
            }
        }
    }
}
