using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DotInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
            int x, y, xSquare, ySquare, r;
            bool check;
            Console.Write("Enter x: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.Write("Enter y: ");
            int.TryParse(Console.ReadLine(), out y);
            r = 5;
            xSquare = x * x;
            ySquare = y * y;
            check = Math.Sqrt(xSquare + ySquare) < r;
            if (check)
            {
                Console.WriteLine("Dot is in the circle.");
            }
            else Console.WriteLine("Dot is not in the circle.");
 

        }
    }
}
