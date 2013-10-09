using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_N_and_X
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + (1!/X) + (2!/X^2) + … + (N!/X^N)
            uint n = 1, x = 1;
            double sum = 1;
            do
            {
                Console.Write("Enter N = ");
                uint.TryParse(Console.ReadLine(), out n);
                Console.Write("Enter X = ");
                uint.TryParse(Console.ReadLine(), out x);  
 
            } while (n < 1 || x < 1);

            while (n > 0)
            {               
                // N!
                double divisor = 1;
                for (uint i = n; i > 1; i--)
                {
                    divisor *= i;                  
                }
                // X^N
                uint xN = 1;
                for (int j = 0; j < n; j++)
                {
                    xN *= x;
                }

                divisor = divisor / xN;
                sum += divisor;
                n--;
                
            }
            Console.WriteLine("Sum is: {0}", sum);

        }
    }
}
