using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class loopDoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ganjil 1-50");
            int i = 1;

            do
            {
                Console.Write($"{i} ");
                i += 2;
            } while (i <= 50);
            Console.WriteLine("\n program selesai");
            Console.ReadLine();
            }
        }
    }
