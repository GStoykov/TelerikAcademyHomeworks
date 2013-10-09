using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01.OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks if given integer is odd or even.
            int a;
            Console.Write("Въведи число: ");
            int.TryParse(Console.ReadLine(), out a);
            if (a % 2 == 0)
            {
                Console.WriteLine("Числото е четно.");
            }
            else Console.WriteLine("Числото е нечетно.");
        }
    }
}
