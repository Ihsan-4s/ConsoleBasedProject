using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class loopFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perkalian 1-10\n");
            for (int i = 1; i <= 10; i++)// Baris
            {
                for (int j = 1; j <= 10; j++)//kolom
                {
                    Console.Write($"{i * j,4}");//4= lebar 4 spasi
                }
                Console.WriteLine();//ganti baris setelah 1 baris
            }
            Console.WriteLine("\nEnter buat keluar");
            Console.ReadLine();
        }
    }
}
