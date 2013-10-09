using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadNumberMethod
{
    class Program
    {

        // Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
        // If an invalid number or non-number text is entered, the method should throw an exception.
        // Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


        static void ReadNumber(int start, int end)
        {
            
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number > start && number < end)
                {
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception.");
            }
        }
        
       

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number in range (1..100): ");
                ReadNumber(1, 100);
            }
        }
    }
}
