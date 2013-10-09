using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Advance_bit_exchanging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer. 
            uint number, p, q, k, diff, firstBits,  lastBits;
            Console.Write("Enter a number: ");
            uint.TryParse(Console.ReadLine(), out number);
            Console.Write("Enter starting bit for smaller series, p = ");
            uint.TryParse(Console.ReadLine(), out p);
            Console.Write("Enter starting bit for bigger series, q = ");
            uint.TryParse(Console.ReadLine(), out q);
            do
            {
            Console.Write("Enter how much bits you want to exchange, k = ");
            uint.TryParse(Console.ReadLine(), out k);
            }while((p + k - 1u) > q );

            diff = Convert.ToUInt32(q - p);

            for (int i = (int)p; i < (p + k); i++)
            {
                firstBits = Convert.ToUInt32(number & (1u << i));
                firstBits >>= i;
                lastBits = Convert.ToUInt32(number & (int)(1u << (int)(i + diff)));
                lastBits >>= (int)(i + diff);
                if ((firstBits == 0) && (lastBits > 0))
                {
                    number = number & (~(1u << (int)(i + diff)));
                    number = number | (lastBits << i);
                }
                else if ((firstBits > 0) && (lastBits == 0))
                {
                    number = number | (firstBits << (int)(i + diff));
                    number = number & (~(1u << i));
                }
            }
            Console.WriteLine(number);
             
        }
    }
}
