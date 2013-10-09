//6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//   Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] arr =new int[14] {-5, 3, 0,-543, 23, 21, 35, 77, 4, 42, 52 ,66, 3771, 24 };

        Console.WriteLine("Finding the numbers that are divisible by 7 and 3 in the array with Lambda expression: ");
        var result1 = arr.Where(x => x % 21 == 0);
        foreach (var num in result1)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();

        Console.WriteLine("Finding the numbers that are divisible by 7 and 3 in the array with LINQ: ");
        var result2 = from num in arr
                      where num % 21 == 0
                      select num;
        foreach (var num in result2)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();


    }
}