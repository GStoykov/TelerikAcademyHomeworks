using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Printing_numbers_until_N
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Write a program that reads an integer number n from the console
              and prints all the numbers in the interval [1..n], each on a single line. */
            int n;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
