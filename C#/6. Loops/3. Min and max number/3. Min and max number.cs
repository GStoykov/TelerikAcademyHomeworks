using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Min_and_max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads from the console a sequence of N integer numbers and returns the minimal and 
               maximal of them. */
            int n, min = 0, max = 0;
            Console.Write("How much integers do you want to enter: ");
            int.TryParse(Console.ReadLine(), out n);
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number: ", i+1);
                int.TryParse(Console.ReadLine(), out num[i]);
            }

            for (int i = 0; i < n; i++)
            {
                min = num[0];
                max = num[0];
                if (min > num[i])
                {
                    min = num[i];
                }
                if (max < num[i])
                {
                    max = num[i];
                }
            }
            Console.WriteLine("Min number is {0}", min);
            Console.WriteLine("Max number is {0}", max);
        }
    }
}
