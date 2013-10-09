using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IntegerStringSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are given a sequence of positive integer values written into a string, separated by spaces.
            // Write a function that reads these values from given string and calculates their sum. 
            // Example: string = "43 68 9 23 318"  result = 461

            string intString = "15 30 20 4 4 2";
            intString = intString.Trim();
            string[] numbers = intString.Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            Console.WriteLine("Sum is: {0}", sum);

        }
    }
}
