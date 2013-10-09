using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Negative_or_positive_product
{
    class Program
    {
        static int Main(string[] args)
        {
            /* Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
               Use a sequence of if statements. */

            double[] number = new double[3];
            string[] word = new string[3] { "first", "second", "third" };
            bool isPositive = true;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter {0} number: ", word[i]);
                double.TryParse(Console.ReadLine(), out number[i]);

                if ( number[i] < 0 )
                {
                    isPositive = !isPositive;
                }

                else if (number[i] == 0)
                {
                    Console.WriteLine("Product is 0");
                    return 0;
                }
            }
            if (isPositive)
            {
                Console.WriteLine("Product is positive.");
            }
            else
            {
                Console.WriteLine("Product is negative.");
            }


            return 0;
        }
    }
}
