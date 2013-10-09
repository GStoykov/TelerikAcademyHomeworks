using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Does_bit_P_has_value_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a boolean expression that returns if the bit at position p (counting from 0) in a given 
               integer number v has value of 1. Example: v=5; p=1 - false. */

            int v = 12, p, mask;
            Console.Write("Enter position: ");
            int.TryParse(Console.ReadLine(), out p);
            mask = 1 << p;
            v = v & mask;
            v >>= p;
            Console.WriteLine("Bit {0} has value {1}.", p, v);

        }
    }
}
