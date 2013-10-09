using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that compares two char arrays lexicographically (letter by letter).
        char[] arr1 = { 'a', 'b', 'c', 'd', 'e' };
        char[] arr2 = { 'a', 'b', 'd', 'd', 'e' };

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine("{0} = {1} : {2}", arr1[i], arr2[i], arr1[i] == arr2[i]);
        }

    }
}
