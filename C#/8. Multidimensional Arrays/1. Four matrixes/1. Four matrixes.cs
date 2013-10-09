using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{


    static void Print(int n, int[,] matrix) 
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int n = 4, counter = 1;
        int[,] matrix = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = counter++;
                
            }
        }
        Print(n, matrix);
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine();

        counter = 1;
        for (int row = 0; row < n; row++)
        {
            if (row % 2 == 0)
            {
               for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = counter++;

                }
            }
            else
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    matrix[col, row] = counter++;

                }
            }
        }

        Print(n, matrix);
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine();

        counter = 1;
        for (int i = 0; i <= n - 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                matrix[n - i + j - 1, j] = counter++;
            }
        }
        for (int i = n - 2; i >= 0; i--)
        {
            for (int j = i; j >= 0; j--)
            {
                matrix[i - j, n - j - 1] = counter++;
            }
        }
        Print(n, matrix);
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine();

    }
}