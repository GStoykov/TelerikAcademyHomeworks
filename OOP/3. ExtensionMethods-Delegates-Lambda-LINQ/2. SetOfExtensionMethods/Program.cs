using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[6];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        Console.WriteLine("The sum of elements: {0}", arr.Sum<int>());
        Console.WriteLine("The product of elements: {0}", arr.Product<int>());
        Console.WriteLine("The average element value: {0}", arr.Average<int>());
        Console.WriteLine("The element with minimum value: {0}", arr.Min<int>());
        Console.WriteLine("The element with maximumx value: {0}", arr.Max<int>());
    }
}
