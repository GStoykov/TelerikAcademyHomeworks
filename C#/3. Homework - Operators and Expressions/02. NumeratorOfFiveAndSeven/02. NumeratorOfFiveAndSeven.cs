using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumeratorOfFiveAndSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a boolean expression that checks for given integer if it can be 
               divided (without remainder) by 7 and 5 in the same time. */
            int number;
            bool check;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out number);
            check = (number % 35 == 0);
            if (check)
            {
                Console.WriteLine("Number can be devided by 7 and 5 in the same time without remainder.");
            }
            else Console.WriteLine("Number can`t be devided by 7 and 5 in the same time without remainder.");
        }
    }
}
