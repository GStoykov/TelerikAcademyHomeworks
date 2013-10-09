using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 12, 0, -5, 3, 27, 54, 2, 16 };
        int combinations = (int)Math.Pow(2, arr.Length) - 1;
        int searchingSum, subsetCounter = 0; // subsetCounter checking if there is at least 2 numbers that are subset
        Console.Write("Searching sum: ");
        int.TryParse(Console.ReadLine(), out searchingSum);
        bool existingSum = false;

        for (int i = 1; i <= combinations; i++)
        {
            int sum = 0;
            subsetCounter = 0;
            for (int j = 1; j <= arr.Length; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    sum += arr[j - 1];
                    subsetCounter++;
                }
            }
            if (sum == searchingSum && subsetCounter > 1)
            {
                existingSum = true;
            }
        }
        if (existingSum)
        {
            Console.WriteLine("Yes.");
        }
        else
        {
            Console.WriteLine("No, there is no such subset sum.");
        }
    }
}