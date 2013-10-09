using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] arr2 = { 1, 9, 3, 4, 5, 6, 7, 15 };

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write("arr1[{0}] =? arr2[{0}]: ", i);
            if (arr1[i] == arr2[i])
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
            Console.WriteLine();
        }

    }
}

