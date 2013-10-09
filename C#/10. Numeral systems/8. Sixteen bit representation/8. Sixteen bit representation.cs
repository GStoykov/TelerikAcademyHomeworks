using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sixteen_bit_representation
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number from -32768 to 32767 : ");
            short number = short.Parse(Console.ReadLine());
            char[] bit = new char[16];
            for (int i = 15; i >= 0; i--)
            {
                if ((number & (1 << i)) != 0)
                {
                    bit[i] = '1';
                }
                else
                {
                    bit[i] = '0';
                }
            }

            Array.Reverse(bit);
            foreach (var elem in bit)
            {
                Console.Write(elem);
            }
            Console.WriteLine();
        }
    }
}

