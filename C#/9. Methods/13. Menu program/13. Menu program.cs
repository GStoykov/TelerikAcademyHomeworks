using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Menu_program
{
    class Program
    {
        //Write a program that can solve these tasks:
        //Reverses the digits of a number
        //Calculates the average of a sequence of integers
        //Solves a linear equation a * x + b = 0

        //        Create appropriate methods.
        //        Provide a simple text-based menu for the user to choose which task to solve.
        //        Validate the input data:

        //The decimal number should be non-negative
        //The sequence should not be empty
        //a should not be equal to 0

        static void ReverseTheDigits()
        {
            Console.WriteLine();
            Console.Write("Enter a number: ");
            decimal number = -1;
            do
            {
                number = decimal.Parse(Console.ReadLine());
            } while (number < 0);
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
            Console.Write("New number is ");
            foreach (var item in newNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void CalculateTheAverageOfASequnce()
        {
            Console.WriteLine();
            int n = 0;
            do
            {
                Console.Write("How much integers you want to enter: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1);

            decimal[] arr = new decimal[n];
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                arr[i] = decimal.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Average sum is: {0}", sum / n);
        }

        static void SolveALinearEquation()
        {
            Console.WriteLine();
            Console.WriteLine("Equation a * x + b = 0");
            decimal a = -1, b = decimal.MinValue;
            do
            {
                Console.Write("a = ");
                a = decimal.Parse(Console.ReadLine());
            } while (a <= 0);

            Console.Write("b = ");
            b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", -b/a);

        }


        static void Main(string[] args)
        {
            Console.WriteLine("\t Menu:");
            Console.WriteLine("1. Reverse the digits of a number");
            Console.WriteLine("2. Calculate the average of a sequence of integers");
            Console.WriteLine("3. Solve a linear equation a * x + b = 0 ");
            Console.WriteLine();
            
            int choice = -1;
            do
            {
                Console.Write("Choose a task 1, 2 or 3: ");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 1 && choice != 2 && choice != 3);

            switch (choice)
            {
                case 1: ReverseTheDigits(); break;
                case 2: CalculateTheAverageOfASequnce(); break;
                default: SolveALinearEquation(); break;
            }
        }
       
    }
}
