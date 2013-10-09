using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._8_TheEuclideanAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
          // Write a program that calculates the greatest common divisor (GCD) of given two numbers.Use the Euclidean algorithm
            int dividend, divisor, remainder;
            Console.Write("Enter the first number: ");
            int.TryParse(Console.ReadLine(), out dividend);
            Console.Write("Enter the second number: ");
            int.TryParse(Console.ReadLine(), out divisor);

            if (dividend < divisor)
            {
                remainder = dividend;
                dividend = divisor;
                divisor = remainder;
                remainder = 0;
            }

            do
            {

                remainder = dividend % divisor;
                dividend = divisor;
                divisor = remainder;

            } while (remainder != 0);

            Console.WriteLine();
            Console.WriteLine("Greatest common divisor is {0}", dividend);
        }
    }
}
