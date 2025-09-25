using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class loopForeach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("daftar nama siswa");
            string[] siswa = { "Asep", "Duta", "isan", "Dedi" };

            foreach(string nama in siswa)
            {
                Console.WriteLine($"- {nama}");
            }
            Console.WriteLine("\nprogram selesai hore");
            Console.ReadLine();
        }
    }
}
