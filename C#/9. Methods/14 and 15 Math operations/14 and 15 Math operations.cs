using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_and_15_Math_operations
{
    class Program
    {

            // Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
            // Use variable number of arguments.
            // 
            // * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
            // Use generic method (read in Internet about generic methods in C#).
        
            static void MinOfSequnce<T>(params T[] arr)
        {
            dynamic min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Smallest number is: {0}", min);
        }
            static void MaxOfSequence<T>(params T[] arr)
        {
            dynamic max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Biggest number is: {0}", max);
        }
            static void AverageOfSequnce<T>(params T[] arr)
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Average sum is: {0}", sum / arr.Length);
        }
            static void SumOfAllNumbers<T>(params T[] arr)
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of all numbers is: {0}", sum);
        }
            static void ProductOfAllNumbers<T>(params T[] arr)
        {
            dynamic product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product = product * arr[i];
            }
            Console.WriteLine("Product of all numbers is: {0}", product);
        }
        
            static void Main()
            {
                
                MinOfSequnce(-3, -53, 34, 0, 2, 4, -5, 14, 1);
                MaxOfSequence(-2, 3, 53, 2, 0, 54, 100, 17);
                AverageOfSequnce(23, 1, 5, 2, 4, 43, 17, 9);
                SumOfAllNumbers(77, 34, 2, -4 , -31, 26, 18);
                ProductOfAllNumbers(21, 11, 32, -45, 99, 4);
            }
    }
}
