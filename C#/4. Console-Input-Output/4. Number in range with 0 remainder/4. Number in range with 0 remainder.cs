using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Number_in_range_with_0_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4. Write a program that reads two positive integer numbers and prints how many numbers p exist between
             * them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2. */
            int a, b, exchange, remainder, sum = 0;
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out b);

            if (a > b)
            {
                exchange = a;
                a = b;
                b = exchange;
            }

            for (int i = a; i <= b; i++)
            {
                remainder = i % 5;
                if (remainder == 0)
                {
                    sum ++;
                }
            }

            Console.WriteLine("There is {0} numbers with remainder 0 by devision of 5 in range ( {1} - {2} ).", sum, a, b);

        }   
    }
}
