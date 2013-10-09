using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 
        int[] arr = { 5, 4, 121, 52, 0, -2, -30, 52, -2 }; // - 30, -2, -2, 0, 4, 5, 52, 52, 121
        int num, middleIndex = arr.Length / 2, last = arr.Length - 1, start = 0;
        Array.Sort(arr);
            Console.Write("Index of which element: ");
            int.TryParse(Console.ReadLine(), out num);
            do
            {
                if (num == arr[middleIndex])
                {
                    Console.WriteLine("Index of the element is: {0}", middleIndex);
                    break;
                }
                else if (num < arr[middleIndex] && start != last)
                {
                    last = middleIndex - 1;
                    middleIndex = last / 2;
                }
                else if (num > arr[middleIndex] && start != last)
                {
                    start = middleIndex + 1;
                    middleIndex = (start + last) / 2;
                }
                else if (start == last)
                {
                    Console.WriteLine("There is no such element.");
                    break;
                }
                
            } while (true);
        
    }
}

