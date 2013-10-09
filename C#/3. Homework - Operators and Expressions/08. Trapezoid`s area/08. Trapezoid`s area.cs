using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trapezoid_s_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that calculates trapezoid's area by given sides a and b and height h.
            int a = 5, b = 3, h = 4, area;
            area = a + b;
            area /= 2;
            area *= h;
            Console.WriteLine("The area is {0}.", area);
        }
    }
}
