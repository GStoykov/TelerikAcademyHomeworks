using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0
               and solves it (prints its real roots). */
            double a, b, c, d, x1, x2;
            Console.Write("Enter a: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter b: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter c: ");
            double.TryParse(Console.ReadLine(), out c);

            d = (b * b) - (4 * a * c);

            if (d < 0)
            {
                Console.WriteLine("There is no real roots.");
            }

            if (d == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                Console.WriteLine("D = 0, real root x = {0}", x1);
            }

            if (d > 0)
            {
                x1 = ((-b) - Math.Sqrt(d)) / 2 * a;
                x2 = ((-b) + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}
