using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the maximal increasing sequence in an array. 
        // Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
     
        // promenlivi
        int n;
        do
        {
            int.TryParse(Console.ReadLine(), out n);
        } while (n < 2);
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        List<int> oldSeq = new List<int>();
        List<int> newSeq = new List<int>();
        
        // sortirane
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                if (newSeq.Count == 0)
                {
                    newSeq.Add(arr[i]);
                    newSeq.Add(arr[i + 1]);    
                }
                else
                {
                    newSeq.Add(arr[i + 1]);    
                }
            }
            else
            {
                if (newSeq.Count > oldSeq.Count)
                {
                    oldSeq.Clear();
                    oldSeq.AddRange(newSeq);
                }
                newSeq.Clear();
            }
        }

        if (newSeq.Count > oldSeq.Count)
        {
            oldSeq.Clear();
            oldSeq.AddRange(newSeq);
        }
        
        if (oldSeq.Count == 0)
        {
            Console.WriteLine("There is no increasing sequence");
        }
        else
        {
            Console.Write("{ ");
            foreach (var item in oldSeq)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("}");
        }
        
    }
}
