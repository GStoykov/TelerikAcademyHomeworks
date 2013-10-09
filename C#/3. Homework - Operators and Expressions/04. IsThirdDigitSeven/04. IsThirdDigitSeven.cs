using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.IsThirdDigitSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732-true.
            int number;
            do
            {
                Console.Write("Enter a four-digit number: ");
                int.TryParse(Console.ReadLine(), out number);
            } while ((number < 999) || (number > 10000));
            number = number % 100; // number is two digit 
            number = number / 10;  // third digit
            if (number == 7)
            {
                Console.WriteLine("Third digit is 7.");
            }
            else Console.WriteLine("Third digit is not 7.");
        }
    }
}
