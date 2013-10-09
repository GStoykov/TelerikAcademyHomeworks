using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Triangle_s_surface
{
    class Program
    {
        static void CalculateTheSurface(decimal side, decimal altitude)
        {
            decimal surface = Math.Abs(side * altitude);
            Console.WriteLine("Surface ot the triangle by given side and altitude is: {0}", surface / 2);
            Console.WriteLine();
        }

        static void CalculateTheSurface(decimal a, decimal b, decimal c)
        {
            decimal halfP = Math.Abs(a + b + c) / 3;
            a = Math.Abs(halfP - a);
            b = Math.Abs(halfP - b);
            c = Math.Abs(halfP - c);
            decimal surface = halfP * a * b *c;
            surface = (decimal)Math.Sqrt((double)surface);
            Console.WriteLine("Surface ot the triangle by given three sides is: {0}", surface);
            Console.WriteLine();
        }

        static void CalculateTheSurfaceWithAngle(decimal a, decimal b, decimal angle)
        {
            decimal surface = Math.Abs(a * b * (decimal)Math.Sin((double)angle));
            Console.WriteLine("Surface ot the triangle by given two sides and the angle between them is: {0}", surface / 2);
            Console.WriteLine();
        }               

        static void Main(string[] args)
        {
            // Write methods that calculate the surface of a triangle by given:
            // Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

            Console.Write("Enter first side: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second side: ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.Write("Enter third side: ");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.Write("Enter an altitude to third side: ");
            decimal h = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the angle between first and second side: ");
            decimal angle = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            CalculateTheSurface(c, h);
            CalculateTheSurface(a, b, c);
            CalculateTheSurfaceWithAngle(a, b, angle);
        }

    }
}
