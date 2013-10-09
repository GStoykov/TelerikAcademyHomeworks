using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10_FactorialUntilHundread
{
    class Program
    {
        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main()
        {
            // Write a program to calculate n! for each n in the range [1..100]. 
            // Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}! = ", i);
                Console.Write(Factorial(i));
                Console.WriteLine();
            }

        }
    }
}
