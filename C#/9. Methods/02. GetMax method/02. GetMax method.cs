using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetMax_method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method GetMax() with two parameters that returns the bigger of two integers.
            // Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            int biggest = GetMax(firstNum, secondNum);
            Console.WriteLine();
            if (biggest < thirdNum)
            {
                Console.WriteLine("Biggest number is: {0}", thirdNum);
            }
            else
            {
                Console.WriteLine("Biggest number is: {0}", biggest);
            }
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
    }
}
    