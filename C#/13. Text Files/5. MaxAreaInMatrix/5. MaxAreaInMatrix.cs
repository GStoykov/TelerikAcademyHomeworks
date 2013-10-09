using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static int[,] MakeIntegerMatrix()
    {
        StreamReader reader = new StreamReader("Matrix.txt");
        using (reader)
        {
            int n = int.Parse(reader.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                string[] numbersInRow = reader.ReadLine().Split(' ');
                for (int column = 0; column < n; column++)
                {
                    matrix[row, column] = int.Parse(numbersInRow[column]);
                }
            }
            return matrix;
        }
    }

    static void FindMaxArea(int[,] matrix)
    {
        int maxArea = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int column = 0; column < matrix.GetLength(1) - 1; column++)
            {
                int sum = matrix[row, column] + matrix[row, column + 1] + matrix[row + 1, column] + matrix[row + 1, column + 1];
                if (sum > maxArea)
                {
                    maxArea = sum;
                }
            }
        }
        Console.WriteLine("Max area 2x2 in matrix is: {0}", maxArea);
    }


    static void Main(string[] args)
    {
        FindMaxArea(MakeIntegerMatrix());
    }







}