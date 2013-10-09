using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Rectangle_s_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that calculates rectangle’s area by given width and height.
            double a, b, area;
            do
            {
                Console.Write("Enter width: ");
                double.TryParse(Console.ReadLine(), out a);
            } while (a == 0);
            do
            {
                Console.Write("Enter height: ");
                double.TryParse(Console.ReadLine(), out b);
            } while (b == 0);

            area = a * b;
            Console.WriteLine("Rectangle`s area is {0}.", area);
        }
    }
}
