using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class dataUmur
    {
        static void Main(string[] args)
        {
            Console.Write("masukan nama anda: ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan Umur Anda: ");
            int umur = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Nama Anda: " + nama + " umur anda " + umur + " tahun");

            if(umur < 0)
            {
                Console.WriteLine("Umur tidak valid");
            }
            else if (umur <= 5)
            {
                Console.WriteLine("Anda adalah balita");
            }
            else if (umur <= 12)
            {
                Console.WriteLine("Anda adalah anak-anak");
            }
            else if (umur <= 19)
            {
                Console.WriteLine("Anda adalah remaja");
            }
            else if (umur <= 59)
            {
                Console.WriteLine("Anda adalah dewasa");
            }
            else
            {
                Console.WriteLine("Anda adalah lansia");
            }
            Console.ReadKey();
        }
    }
}
