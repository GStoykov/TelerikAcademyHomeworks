﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Digit_with_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write program that asks for a digit and depending on the input shows the name of that
               digit (in English) using a switch statement. */
            int number;
            Console.Write("Enter a digit[0..9] : ");
            int.TryParse(Console.ReadLine(), out number);
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("There is more than one or negative digit.");
                    break;
            }
        }
    }
}
