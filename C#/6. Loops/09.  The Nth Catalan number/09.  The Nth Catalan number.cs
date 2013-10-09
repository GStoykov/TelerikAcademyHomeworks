using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.The_Nth_Catalan_number
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n, diff, numerator = 1, denominator;
            Console.Write("Enter N: ");
            uint.TryParse(Console.ReadLine(), out n);

            diff = 2 * n;
            denominator = n + 1;
            while (diff > denominator )
            {
                numerator *= diff;
                diff--;
            }

            denominator = 1;
            while (n > 1)
            {
                denominator *= n;
                n--;
            }

            Console.WriteLine("The Catalan number is: {0}", numerator / denominator );
            
        }
    }
}
