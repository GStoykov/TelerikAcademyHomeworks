using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MaxElementInArrayPortion
{
    class Program
    {
        // { 1, 5, 2, -3, 543, 23, 35, 1, 15}
        static int maxElementMethod(int startIndex ,int[] arr)
        {
            int maxElement = arr[startIndex];
            for (int i = startIndex; i < arr.Length ; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                    int exchangeValues = arr[i];
                    arr[i] = arr[startIndex];
                    arr[startIndex] = exchangeValues;
                }
                
            }
            return maxElement;
        }

        static void SortMethodDescending(int[] arr)
        {
            List<int> descList = new List<int>();
            for (int i = 0; i < arr.Length ; i++)
            {
                descList.Add(maxElementMethod(i, arr));
            }
            Console.Write("Descending: ");
            Print(descList);
            SortMethodAscending(descList);
        }

        static void SortMethodAscending(List<int> descList)
        {
            List<int> ascList = new List<int>();
            for (int i = descList.Count - 1; i >= 0; i--)
            {
                ascList.Add(descList[i]);
            }
            Console.Write("Ascending: ");
            Print(ascList);
        }

        private static void Print(List<int> descList)
        {
            foreach (var elem in descList)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Write a method that return the maximal element in a portion of array of integers starting at given index.
            // Using it write another method that sorts an array in ascending / descending order.

            int[] arr = { 1, 5, 2, -3, 543, 23, 35, 1, 15}; // 543, 35, 23, 15 , 5, 2, 1, 1, -3
            Console.Write("Enter the start index for array`s portion (array has {0} elements): ", arr.Length);
            int startIndex = int.Parse(Console.ReadLine());
            int maxElement = maxElementMethod(startIndex, arr);
            Console.WriteLine("Max element is: {0}",maxElement);
            SortMethodDescending(arr);
            
        }

    }
}
