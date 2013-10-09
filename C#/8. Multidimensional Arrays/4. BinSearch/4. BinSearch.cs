using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 6, 4, 0, 2, 2, 5, 7, 12, 20 };
        int k;
        Console.Write("Enter K: ");
        int.TryParse(Console.ReadLine(), out k);

        Array.Sort(arr);
       
        // if num >= 0, element exist
        // else it returns number, which after "~" shows the index of first existing number larger than K in the array

        int num = Array.BinarySearch(arr, k);

        if (~num == 0)
        {
            Console.WriteLine("There is no such number");
        }
        else if (num < -1)
        {
            Console.WriteLine("Largest number < {0} is: {1}", k, arr[~num - 1]);
        }
        else
        {
            Console.WriteLine("Element = {0} is found!", k, arr[num]);
        }
    }
}