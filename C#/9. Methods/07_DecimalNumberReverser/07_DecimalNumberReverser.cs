using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DecimalNumberReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that reverses the digits of given decimal number. Example: 256 --> 652
            Console.Write("Enter a number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            PrintTheNumber(ReverseTheNumber(number));
        }       

        private static List<char> ReverseTheNumber(decimal number)
        {
            List<char> newNumber = new List<char>();
            string numberInString = number.ToString();
            if (number < 0)
            {
                newNumber.Add(numberInString[0]);
                for (int i = numberInString.Length - 1; i > 0; i--)
                {
                    newNumber.Add(numberInString[i]);
                }
            }
            else
            {
                for (int i = numberInString.Length - 1; i >= 0; i--)
                {
                    newNumber.Add(numberInString[i]);
                }
            }            
            return newNumber;
        }

        private static void PrintTheNumber(List<char> newNumber)
        {
            Console.Write("New number is ");
            foreach (var item in newNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
