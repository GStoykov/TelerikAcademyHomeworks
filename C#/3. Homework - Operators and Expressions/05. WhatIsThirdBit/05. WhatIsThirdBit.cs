using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WhatIsThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
            int number;
            bool check;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out number);
            number = number & 8;
            check = (number == 8);
            if (check)
            {
                Console.WriteLine("Third digit is 1.");
            }
            else Console.WriteLine("Third digit is 0.");
        }
    }
}
