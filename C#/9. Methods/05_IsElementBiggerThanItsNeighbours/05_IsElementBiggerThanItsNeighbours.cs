using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IsElementBiggerThanItsNeighbours
{
    public class Program5
    {
        static void Main(string[] args)
        {
          // Write a method that checks if the element at given position 
          // in given array of integers is bigger than its two neighbors (when such exist).
            int[] arr = {4, 53, 23, 66, 1, 5, -4, 5, 3, 29, 242, 99, 23, 10 };
            Console.WriteLine("The array has {0} elements.", arr.Length);
            int elemIndex = 0;
            do
            {
                Console.Write("Element`s position in the array (from 1 to {0}): ", arr.Length - 2);
                int.TryParse(Console.ReadLine(), out elemIndex);
            } while (elemIndex < 1 || elemIndex > arr.Length -2);

            if (IsElemBiggerThanHisNeighbours(elemIndex, arr) == elemIndex)
            {
                Console.WriteLine("Is the element bigger than his two neighbours: True");
            }
            else
            {
                Console.WriteLine("Is the element bigger than his two neighbours: False");
            }
        
        }

        public static int IsElemBiggerThanHisNeighbours(int elemIndex, int[] arr)
        {
            if (arr[elemIndex] > arr[elemIndex - 1] && arr[elemIndex] > arr[elemIndex + 1])
            {
                return elemIndex;
            }
            else
            {
                return -1;
            }
        }
    }
}
