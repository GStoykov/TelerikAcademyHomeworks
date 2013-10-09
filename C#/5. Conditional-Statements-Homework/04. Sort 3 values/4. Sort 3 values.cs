using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_3_values
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort 3 real values in descending order using nested if statements.
            int a, b, c;
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("c = ");
            int.TryParse(Console.ReadLine(), out c);

            if ((a < b || a < c) || (a < b && a < c))
            {               
                if (a < b)
                {
                    int exValue; // exchange value
                    exValue = a;
                    a = b;
                    b = exValue;
                }
                if (a < c )
                {
                    int exValue;
                    exValue = a;
                    a = c;
                    c = exValue;
                }
            }

            if ((b < a || b < c) || (b < a && b < c))
            {
                if (b < a)
                {
                    int exValue; // exchange value
                    exValue = b;
                    b = a;
                    a = exValue;
                }
                if (b < c)
                {
                    int exValue;
                    exValue = b;
                    b = c;
                    c = exValue;
                }
            }

            if ((c < b || c < a) || (c < b && c < a))
            {
                if (c < b)
                {
                    int exValue; // exchange value
                    exValue = c;
                    c = b;
                    b = exValue;
                }
                if (c < a)
                {
                    int exValue;
                    exValue = c;
                    c = a;
                    c = exValue;
                }
                Console.WriteLine("Greater number is {0}", c);
            }
            if ( a == b && a == c)
            {
                Console.WriteLine("Greater number is {0}", c);
            }
        }
    }
}
