using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class absensiArraytest
    {
        static void Main(string[] args)
        {
            Console.Write("masukan jumlah siswa");
            int jumlah = int.Parse(Console.ReadLine());

            string[] nama = new string[jumlah];
            string[] status = new string[jumlah];

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write($"nama siswa ke {i+1} = ");
                nama[i]= Console.ReadLine();
                Console.Write("status hadir/sakit/alpa = ");
                status[i]= Console.ReadLine();
            }
            Console.WriteLine("\n rekap absensi");
            for(int i = 0; i < jumlah; i++)
            {
                Console.WriteLine($"{nama[i]} - {status[i]}");
            }
        }
    }
}
