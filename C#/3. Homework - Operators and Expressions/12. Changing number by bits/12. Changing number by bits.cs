using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Changing_number_by_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We are given integer number n, value v (v=0 or 1) and a position p. 
               Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	           Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	           n = 5 (00000101), p=2, v=0  1 (00000001) */
            int n, p, v, mask;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter position: ");
            int.TryParse(Console.ReadLine(), out p);
            do
            {
                Console.Write("Enter value 0 or 1 : ");
                int.TryParse(Console.ReadLine(), out v);   
             
            } while (v < 0 || v > 1);

            if (v == 1)
            {
                mask = 1 << p;
                n = n | mask;
                Console.WriteLine("New number is {0}.", n);
            }

            if (v == 0)
            {
                mask = 1 << p;
                mask = ~ mask;
                n = n & mask;
                Console.WriteLine("New number is {0}.", n);
            }

        }
    }
}
