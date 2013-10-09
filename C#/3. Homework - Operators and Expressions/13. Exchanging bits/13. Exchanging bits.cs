using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Exchanging_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
            uint number, firstBits, lastBits;          
            Console.Write("Enter a number: ");
            uint.TryParse(Console.ReadLine(), out number);
            
            for (int i = 3; i < 6; i++)
            {
                firstBits = Convert.ToUInt32(number & (1u << i));
                firstBits >>= i;
                lastBits = Convert.ToUInt32(number & (1u << (i + 21)));
                lastBits >>= (i + 21);
                if ((firstBits == 0) && (lastBits > 0))
                {
                    number = number & (~(1u << (i + 21)));
                    number = number | (lastBits << i);                                 
                }
                else if ((firstBits > 0) && (lastBits == 0))
                {
                    number = number | (firstBits << i + 21);
                    number = number & (~(1u << i));     
                }
            }
            Console.WriteLine("Number is {0}.",number);
        }
    }
}
