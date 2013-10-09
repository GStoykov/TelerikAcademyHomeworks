using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Value_exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write an if statement that examines two integer variables and exchanges
               their values if the first one is greater than the second one. */
            int smaller, bigger;
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out smaller);
            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out bigger);
            if (smaller > bigger)
            {
                int exValue;
                exValue = smaller;
                smaller = bigger;
                bigger = exValue;
                Console.WriteLine("First number: {0}", smaller);
                Console.WriteLine("Second number: {0}", bigger);
            }
            else
            {
                Console.WriteLine("First number: {0}", smaller);
                Console.WriteLine("Second number: {0}", bigger);
            }
        }
    }
}
