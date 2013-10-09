using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            // Write a method that counts how many times given number appears in given array.
            // Write a test program to check if the method is working correctly.

            Console.Write("Searching element: ");
            int number = int.Parse(Console.ReadLine());
            int[] arr = { -5, 3, 4, 123, 43, -42, 82, 15, 0, 4, 2, 1, 11, 29, 54, 23 };
            int counter = ElementCounter(number, arr);
            Console.WriteLine("The array has {0} elements with value {1}.", counter, number);
        }

        public static int ElementCounter(int number, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (number == arr[i])
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
