using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the most frequent number in an array.
    	// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 1, 1, 3} --> 4 (5 times)

        int n;
        int.TryParse(Console.ReadLine(), out n);
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        List<int> frequency = new List<int>();
        int freq, bestFreq, elem, bestElem;
        freq = bestFreq = 0;
        elem = bestElem = 0;
        

        for (int i = 0; i < arr.Length - 1; i++)
        {
            elem = arr[i];
            freq = 0;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (elem == arr[j])
                {
                    freq++;
                }
                if (j == arr.Length - 1)
                {
                    if (freq > bestFreq)
                    {
                        bestFreq = freq;
                        frequency.Clear();
                        frequency.Add(elem);
                    }
                    else if (freq == bestFreq)
                    {
                        frequency.Add(elem);
                    }
                }
                
            }    
        }
        Console.WriteLine();
        foreach (var item in frequency)
        {
            if (frequency.Count > 1)
            {
                Console.Write(item + ", ");
            }
            else
            {
                Console.Write(item + " ");
            }
        }
        Console.Write("({0} times)", bestFreq + 1);
        Console.WriteLine();

    }
}
