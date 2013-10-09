using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _09.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program to print the first 100 members of 
               the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */

            BigInteger sum = 0;
            BigInteger a = 0;
            BigInteger b = 1;
            Console.WriteLine(0);

            for (int i = 0; i < 99; i++)
            {
                sum = a + b;
                Console.WriteLine(sum);
                if (a < b)
                {
                    a = sum;
                }
                else b = sum;
            }
        }
    }
}
