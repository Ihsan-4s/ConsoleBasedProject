using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class Nilai2
    {
        static void Main(string[] args) 
        {
            int nilai = 80;
            string predikat;

            switch (nilai / 10)
            {
                case 10:
                case 9:
                case 8:
                    predikat = "A";
                    break;
                case 7:
                    predikat = "B";
                    break;
                case 6:
                    predikat = "C";
                    break;
                case 5:
                    predikat = "D";
                    break;
                default:
                    predikat = "E";
                    break;
            }

            Console.WriteLine("Predikat Anda: " + predikat);


        }

    }
}
