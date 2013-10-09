using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Longest_sequence_of_equel_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // We are given a matrix of strings of size N x M. 
            // Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
            // Write a program that finds the longest sequence of equal strings in the matrix.
            int n, m, seq = 1, longestSeq = 1;
            //Console.Write("Enter N: ");
            //int.TryParse(Console.ReadLine(), out n);
            //Console.Write("Enter M: ");
            //int.TryParse(Console.ReadLine(), out m);
            n = 3;
            m = 4;

            List<string> seqList = new List<string>();
            string[,] matrix = {    {"bb", "Cb", "bb", "bb"},
                                    {"ab", "bdsb", "bfsb", "ee"},
                                    {"acb", "bfsdfb", "bb", "oo"},
                               };

            // Row sequence loop
            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < m - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        seq++;
                    }
                    else
                    {
                        if (seq > longestSeq)
                        {
                            longestSeq = seq;
                        }
                        seq = 1;
                    }
                    if (seq > longestSeq)
                    {
                        longestSeq = seq;
                    }
                }
            }
            seq = 1;
                
            // Column sequnce loop
            for (int row = 0; row < m - 1; row++)
            {
                for (int col = 0; col < n - 1; col++)
                {
                    if (matrix[col, row] == matrix[col + 1, row])
                    {
                        seq++;
                    }
                    else
                    {
                        if (seq > longestSeq)
                        {
                            longestSeq = seq;
                        }
                        seq = 1;
                    }
                    if (seq > longestSeq)
                    {
                        longestSeq = seq;
                    }
                }
            }
            seq = 1;

            // Right diagonal sequence
            for (int i = 0; i < n - 1; i++)
            {
                if (matrix[i, i] == matrix[i+ 1, i + 1])
                {
                    seq++;
                }
                else
                {
                    if (seq > longestSeq)
                    {
                        longestSeq = seq;
                    }
                    seq = 1;
                }
                if (seq > longestSeq)
                {
                    longestSeq = seq;
                }
            }

            seq = 1;
            // Left diagonal sequence
            for (int i = n - 1; i > 0; i--)
            {
                if (matrix[i, i] == matrix[i - 1, i -1])
                {
                    seq++;
                }
                else
                {
                    if (seq > longestSeq)
                    {
                        longestSeq = seq;
                    }
                    seq = 1;
                }
                if (seq > longestSeq)
                {
                    longestSeq = seq;
                }
            }

            Console.WriteLine(longestSeq);
            
        }
    }
}
