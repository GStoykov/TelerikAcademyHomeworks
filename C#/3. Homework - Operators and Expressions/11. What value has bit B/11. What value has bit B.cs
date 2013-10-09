using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.What_value_has_bit_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 - value=1.
            int i, b, mask;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out i);
            Console.Write("Enter position: ");
            int.TryParse(Console.ReadLine(), out b);
            mask = 1 << b;
            i = i & mask;
            i = i >> b;
            if (i == 1)
            {
                Console.WriteLine("Bit {0} has value 1.", b);
            }
            else Console.WriteLine("Bit {0} has value 0.", b);
        }
    }
}
