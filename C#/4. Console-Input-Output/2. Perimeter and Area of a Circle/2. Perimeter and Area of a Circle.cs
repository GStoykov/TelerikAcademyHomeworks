using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Perimeter_and_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a program that reads the radius r of a circle and prints its perimeter and area.
            int r;
            float pi = 3.14159f;
            Console.Write("Enter r: ");
            int.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("Perimeter of the circle is {0}", 2 * pi * r);
            Console.WriteLine("Area of the circle is {0}", pi * r * r);
        }
    }
}
