using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:  
            int n;
            do
            {
            Console.Write("Enter N: ");
            int.TryParse(Console.ReadLine(), out n);
            }while(n < 1 || n > 19);
 
            Console.WriteLine();
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
		        {
                    matrix[i, j] = j + (i + 1);
                    Console.Write(matrix[i,j] + "\t");
		        }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
