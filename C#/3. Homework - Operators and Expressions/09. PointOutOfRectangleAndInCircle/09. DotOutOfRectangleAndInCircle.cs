using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DotOutOfRectangleAndInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write an expression that checks for given point (x, y) if it is within 
               the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2). */
            decimal x, y, r, xSqaure, ySquare;
            bool inCircle;
            Console.Write("Enter x: ");
            decimal.TryParse(Console.ReadLine(), out x);
            Console.Write("Enter y: ");
            decimal.TryParse(Console.ReadLine(), out y);
            
            // Condition about dot in Circle
            r = 3.0M;
            xSqaure = (x * x) - 1;
            ySquare = (y * y) - 1;
            inCircle = (xSqaure + ySquare) < (r * r);


            if (inCircle)
            {
                if ((y > 1) || (y < -1) || (((y > -1) && (y < 1)) && (x < -1))) 
                {
                    Console.WriteLine("Dot is in the circle and out of the rectangle.");
                }
                else Console.WriteLine("Dot is out of the circle or in the rectangle.");
            }
            else Console.WriteLine("Dot is out of the circle or in the rectangle.");
        }
    }
}
