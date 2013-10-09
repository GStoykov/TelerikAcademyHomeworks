using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.N_members_of_Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number N and calculates 
            // the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
            uint n, newNum = 0, num1 = 0, num2 = 1, sum = 1;
            do
            {
                Console.Write("How much members do you want to sum: ");
                 uint.TryParse(Console.ReadLine(), out n);

            } while (n < 2);

            if (n == 2)
            {
                Console.WriteLine("Result is: 1");
            }
            else
            {
                for (int i = 3; i < n + 1; i++)
                {
                    if (num1 < num2)
                    {
                        num1 = newNum;
                        newNum = newNum + num2;
                    }
                    else
                    {
                        num2 = newNum;
                        newNum = newNum + num1;
                    }
                    sum += newNum;
                }
                Console.WriteLine("Result is: {0}", sum);
            }

        }
    }
}
