using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class Nilai
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai Anda: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            string grade;

            if(nilai >= 90)
            {
                grade = "A";
            } else if(nilai >= 80)
            {
                grade = "B";
            } else if(nilai >= 70)
            {
                grade = "C";
            } else if(nilai >= 60)
            {
                grade = "D";
            } else
            {
                grade = "E";
            }
            Console.WriteLine("Grade Anda: " + grade);
        }
    }
}
