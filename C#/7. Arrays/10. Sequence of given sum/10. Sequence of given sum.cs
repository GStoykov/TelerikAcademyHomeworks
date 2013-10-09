using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds in given array of integers a sequence of given sum S (if present).
        // Example:	{4, 3, 1, 4, 2, 5, 8}, S = 11 --> {4, 2, 5}


        // This solution register only first possible sequnce.
        int s, n, sum, elemCounter = 1;
        Console.Write("Sum = ");
        int.TryParse(Console.ReadLine(), out s);
        Console.Write("Elements in array = ");
        int.TryParse(Console.ReadLine(), out n);
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        List<int> seq = new List<int>();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            sum = arr[i];
            seq.Add(arr[i]);
            elemCounter = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                sum += arr[j];
                seq.Add(arr[j]);
                elemCounter++;
                if (sum == s && elemCounter > 2)
                {
                   
                    break;
                }
            }
            if (sum != s)
            {
                seq.Clear();
            }
            else
            {
                break;
            }
        }
        Console.Write("{ ");
        foreach (var item in seq)
        {
            Console.Write(item + ", ");
        }
        Console.Write("}");
        Console.WriteLine();
    }
}
