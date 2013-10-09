using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Greater_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.  Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
            int a, b, c;
            bool check;
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out b);
            check = a > b;
            c = check ? a : b;
            Console.WriteLine("Greater number is {0}.", c);
        }
    }
}
