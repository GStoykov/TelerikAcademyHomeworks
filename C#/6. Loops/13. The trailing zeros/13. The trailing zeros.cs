using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.The_trailing_zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n, count = 1, div = 1;
            do
            {
                Console.Write("Enter N: ");
                BigInteger.TryParse(Console.ReadLine(), out n);
            } while (n < 2);

            // N!
            while (n > 1)
            {
                count *= n;
                n--;
            }

            n = count;
            Console.WriteLine("N! = {0}", n);
            count = 0;

            while (true)
            {
                div = n % 5;
                if (div == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                n = n / 5;
            }
           Console.WriteLine("Zeros: {0}", count);

        }
    }
}
