using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
            double n, k, sum = 0;
            Console.Write("How much numbers do you like to sum: ");
            double.TryParse(Console.ReadLine(), out k);
            Console.Write("Enter number: ");
            double.TryParse(Console.ReadLine(), out n);
            sum = n;

            for (int i = 0; i < (k-1); i++)
            {
                Console.Write("Enter number: ");
                double.TryParse(Console.ReadLine(), out n);                
                Console.WriteLine("{0} + {1} = {2}", sum, n, sum + n);
                sum += n;
            }
            
        }
    }
}
