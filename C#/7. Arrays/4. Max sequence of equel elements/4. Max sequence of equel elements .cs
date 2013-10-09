using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that finds the maximal sequence of equal elements in an array.
        // Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

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


        int counter = 0, maxSeq = 0, repElement = 0;
        bool isSeq = false;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1]) // ако има поредица
            {
                counter++;
                if (counter > maxSeq)
                {
                    repElement = arr[i];                 
                }
            }
            else                      // ако няма поредица 
            {
                if (counter > maxSeq)
                {
                    maxSeq = counter;
                    repElement = arr[i];                 
                }
                counter = 0;
            }
        }
        if (counter > maxSeq)
        {
            maxSeq = counter;
        }

        if (maxSeq == 0 )
        {
            Console.WriteLine("There is no sequence.");
        }
        else
        {
            for (int i = 0; i <= maxSeq; i++)
            {
                Console.Write(repElement + " ");
            }
            Console.WriteLine();
        }
        
    }
}
