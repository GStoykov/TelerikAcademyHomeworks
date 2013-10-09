using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int k, n, sum = 0;

        // Input
        int.TryParse(Console.ReadLine(), out n);
        do
        {
            int.TryParse(Console.ReadLine(), out k);
        } while (k > n);

        // Filling the array
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        // Sorting and reversing array
        Array.Sort(arr);
        Array.Reverse(arr);
        
        // Adding biggest K elements from the array
        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }

        // Output
        Console.WriteLine(sum);
        
    }
}

