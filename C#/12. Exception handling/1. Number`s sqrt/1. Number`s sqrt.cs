using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Number_s_sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads an integer number and calculates and prints its square root. 
            // If the number is invalid or negative, print "Invalid number".
            // In all cases finally print "Good bye". Use try-catch-finally.

            Console.Write("Enter a number: ");
            try
            {
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine("Number`s sqrt is: {0}", Math.Sqrt(number));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally 
            {
                Console.WriteLine("Good bye");
            }
            
        }
    }
}
