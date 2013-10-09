using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        int n, smallest, exch;
        // Input
        int.TryParse(Console.ReadLine(), out n);

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        //int[] arr = {8, 3, 8, 1, 2, 14, 5};       // 1, 1, 2, 3, 5, 8, 14

        for (int i = 0; i < arr.Length - 1; i++)
        {
            
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    exch = arr[i];
                    arr[i] = arr[j];
                    arr[j] = exch;
                }
                else if (arr[i] == arr[j])
                {
                    exch = arr[i + 1];
                    arr[i + 1] = arr[j];
                    arr[j] = exch;
                }
            }
        }
        foreach (var elem in arr)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();
    }
}

