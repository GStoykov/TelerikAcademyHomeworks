using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ConvertFromDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int number = int.Parse(Console.ReadLine());
            List<int> binNumber = new List<int>();
            
            int remainder = 0;
            do
            {

                remainder = number % 2;
                number = number / 2;
                binNumber.Add(remainder);

            } while (number > 0);

            binNumber.Reverse();

            foreach (var bit in binNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
