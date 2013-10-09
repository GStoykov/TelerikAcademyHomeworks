using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_3_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.

            int a, b, c;
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("c = ");
            int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Sum is {0}", a + b + c);
        }
    }
}
