using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Matrix<int> matrix1 = new Matrix<int>(3, 3);
        for (int row = 0; row < matrix1.Rows; row++)
        {
            for (int col = 0; col < matrix1.Cols; col++)
            {
                matrix1[row, col] = ++row;
                row--;
            }
        }

        Console.WriteLine(matrix1);
        Matrix<int> matrix2 = matrix1;
  
        //// Sum of 2 matrixes
        //Matrix<int> result1 = matrix1 + matrix1;
        //Console.WriteLine(result1);

        //// Subtraction of 2 matrixes
        //Matrix<int> result2 = matrix1 - matrix2;
        //Console.WriteLine(result2);

        // Multiplication of 2 Matrixes
        //Matrix<int> matrix1 = new Matrix<int>(3, 2);
        //matrix1[0, 0] = 1;
        //matrix1[0, 1] = 3;
        //matrix1[1, 0] = 0;
        //matrix1[1, 1] = -2;
        //matrix1[2, 0] = 4;
        //matrix1[2, 1] = 1;

        //Matrix<int> matrix2 = new Matrix<int>(2, 2);
        //matrix2[0, 0] = 7;
        //matrix2[0, 1] = 9;
        //matrix2[1, 0] = 5;
        //matrix2[1, 1] = 2;

        //Matrix<int> result3 = matrix1 * matrix2;
        //Console.WriteLine(result3);

        // True of False
        if (matrix1)
        {
            Console.WriteLine("There is NO element with value 0!");
        }
        else
        {
            Console.WriteLine("There is element with value 0!");
        }
    }
}
