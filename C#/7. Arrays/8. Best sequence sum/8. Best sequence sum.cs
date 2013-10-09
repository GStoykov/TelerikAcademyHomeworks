using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the sequence of maximal sum in given array. Example:
        // {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} --> {2, -1, 6, 4}
	    // Can you do it with only one loop (with single scan through the elements of the array)?
        int n;
        int.TryParse(Console.ReadLine(), out n);
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);    
        }

        List<int> seq = new List<int>();
        int sum, bestSum, start, end, exch;
        sum = bestSum = arr[0];
        start = exch = end = 0;
        // Find sequence by looping through
        for (int i = 1; i < arr.Length; i++)
        {
            // calculate sum
            sum += arr[i];
            if (arr[i] > sum)
            {
                sum = arr[i];
                exch = i;
            }
            // calculate bestSum
            if (sum > bestSum)
            {
                bestSum = sum;
                start = exch;
                end = i;
            }
        }

        Console.Write("{ ");
        for (int i = start; i <= end ; i++)
        {
            Console.Write(arr[i] + " ");
        }
        
        Console.Write("}");
        Console.WriteLine();
    }
}
