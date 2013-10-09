using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Spiral_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a positive integer number N (N < 20) from console
            // and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

            int n, counter = 0, lastNum = 0;
            do
            {
                Console.Write("Enter N: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 1 || n > 19);
            int[,] matrix = new int[n,n];
            int numLoops = n / 2;
            Console.WriteLine();

            // UP row and RIGHT column
            for (int upRight = 0; upRight < numLoops; upRight++)
            {
                int lastCol = 0;
                for (int row = upRight; row < n; row++)         // ROW
                {
                    for (int col = upRight; col < n; col++)     // COLUMN
                    {
                        if (counter > matrix.Length)
                        {
                            break;
                        }
                        else if (lastCol == n - 1)
                        {
                            matrix[row, lastCol] = (++counter);
                            break;
                        }
                        else 
                        {
                            matrix[row, col] = (++counter);
                            lastCol = col;
                        }
                    }
                }
                // DOWN row and LEFT column 
                    for (int row = n - 1; row > upRight; row--)
                    {
                        for (int col = row - 1; col >= upRight; col--)
                        {
                            if (counter > matrix.Length)
                            {
                                break;
                            }
                            else if (lastCol == upRight)
                            {
                                matrix[row, lastCol] = (++counter);
                                break;
                            }
                            else
                            {
                                matrix[row, col] = (++counter);
                                lastCol = col;
                            }
                        }
                    }
                n--; 
            }

            if (matrix.GetLength(0) % 2 != 0)
            {
                lastNum = numLoops;
                matrix[lastNum, lastNum] = matrix.Length;
            }




// ----------------------------------------------------------------------
//          OUTPUT 
            if (matrix.GetLength(0) == 1)
            {
                Console.WriteLine(1);
                Console.WriteLine();
            }
            else
            {
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(0); cols++)
                    {
                        Console.Write(matrix[rows, cols] + "\t");
                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}
