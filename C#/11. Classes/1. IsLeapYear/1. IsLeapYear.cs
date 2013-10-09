using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IsLeapYear
{
    class IsLeapYear
    {
        static void Main(string[] args)
        {
           // Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
            
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Year is leap.");
            }
            else
            {
                Console.WriteLine("Year is not leap.");
            }

        }
    }
}
