using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = {
            {1,   2,  3,  4,  5,  6},
            {7,   8,  9, 10, 11 ,12},
            {13, 14, 15, 16, 17, 18} 
        };
        int bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col]     + matrix[row, col + 1]     + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                    bestSum = sum;
            }
        Console.WriteLine("Best sum is {0}.",bestSum);
    }
}
