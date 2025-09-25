using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class loopWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilangan kelipatan 2");

            int i = 2;
            while (i < 50)
            {
                Console.Write($"{i} ");
                i += 2;
            }
            Console.WriteLine("program selesai");
            Console.ReadLine();
        }
    }
}
