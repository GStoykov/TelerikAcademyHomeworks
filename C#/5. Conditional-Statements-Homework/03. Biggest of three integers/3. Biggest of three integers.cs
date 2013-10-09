using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Biggest_of_three_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the biggest of three integers using nested if statements.
            int a, b, c;
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("c = ");
            int.TryParse(Console.ReadLine(), out c);
            if (a < b)
            {
                a = b;
            }
            if (a < c)
            {
                a = c;
            }
            Console.WriteLine("Biggest number is {0}", a);
        }
    }
}
