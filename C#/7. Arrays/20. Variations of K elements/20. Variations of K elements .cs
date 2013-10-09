using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static int k;
    static int n;
    static int[] arr;

    static void Main(string[] args)
    {

        Console.Write("Enter N: ");
        n = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter K: ");
            k = int.Parse(Console.ReadLine());
        } while (k > n || k <1);
        

        arr = new int[k];
        NestedLoops(0);
    }

    static void NestedLoops(int nestedLoopNumber)
    {
        if (nestedLoopNumber == k)
        {
            PrintArray();
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            arr[nestedLoopNumber] = i;
            NestedLoops(nestedLoopNumber + 1);
        }
    }

    static void PrintArray()
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }


}

