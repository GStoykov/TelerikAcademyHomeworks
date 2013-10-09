// 8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

// 9. Implement an indexer this[row, col] to access the inner matrix cells.

// 10. Implement the operators + and - (addition and subtraction of matrices of the same size)
// and * for matrix multiplication. Throw an exception when the operation cannot be performed.
// Implement the true operator (check for non-zero elements).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
{
    // FIELDS
    private readonly int rows;
    private readonly int cols;
    private T[,] matrix;

    // CONSTRUCTORS
    public Matrix(int row, int col, T[,] matrix)
    {
        this.rows = row;
        this.cols = col;
        this.matrix = matrix;
    }

    public Matrix(int row, int col) :this(row, col, new T[row,col])
    {
    }

    public Matrix() :this(0, 0, new T[0, 0])
    {
        
    }

    // PROPERTIES
    public T this[int i, int j]
    {
        get
        {
            isIndexValid(i, j);
            return matrix[i, j];
        }
        set
        {
            isIndexValid(i, j);
            matrix[i, j] = value;
        }      
    }

    public int Cols
    {
        get
        {
            return cols;
        }

    }

    public int Rows
    {
        get
        {
            return  rows;
        }
    }

    public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
    {
        Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
        if (first.cols == second.cols && first.rows == second.rows)
        {
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    dynamic firstMatrixElem = first[i, j];
                    dynamic secondMatrixElem = second[i, j];
                    resultMatrix[i, j] = firstMatrixElem + secondMatrixElem;
                }
            }
            return resultMatrix;
        }
        else
        {
            throw new ArgumentException("Matrix dont have even rows or columns.");
        }
    }

    public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
    {
        Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
        if (first.cols == second.cols && first.rows == second.rows)
        {
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    dynamic firstMatrixElem = first[i, j];
                    dynamic secondMatrixElem = second[i, j];
                    resultMatrix[i, j] = firstMatrixElem - secondMatrixElem;
                }
            }
            return resultMatrix;
        }
        else
        {
            throw new ArgumentException("Matrix dont have even rows or columns.");
        }
    }

    public static Matrix<T> operator *(Matrix<T> firstM, Matrix<T> secondM)
    {
        Matrix<T> resultMatrix = new Matrix<T>(firstM.rows, firstM.cols);
        if (firstM.cols == secondM.rows)
        {
            for (int row = 0; row < firstM.rows; row++)
            {
                for (int col = 0; col < firstM.cols; col++)
                {
                    int elementSum = 0;
                    for (int i = 0; i < firstM.cols; i++)
                    {
                        elementSum += (dynamic)firstM[row, i] * (dynamic)secondM[i, col];
                    }
                    resultMatrix[row, col] = (dynamic)elementSum;
                }
            }
            return resultMatrix;
        }
        else
        {
            throw new ArgumentException("Matrix dont have even rows or columns.");
        }
    }

    // Matrix`s indexes check
    private void isIndexValid(int rowIndex, int colIndex)
    {
        if (rowIndex < 0 || colIndex < 0 || rowIndex > this.rows || colIndex > this.cols)
        {
            throw new IndexOutOfRangeException("There is no such element.");
        }
    }

    // Implement the true operator (check for non-zero elements).
    public static bool operator true(Matrix<T> matrix)
    {
        int zero = 0;
        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.cols; j++)
            {
                if (matrix[i, j].CompareTo(Convert.ChangeType(zero, typeof(T))) == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        int zero = 0;
        for (int i = 0; i < matrix.rows; i++)
        {
            for (int j = 0; j < matrix.cols; j++)
            {
                if (matrix[i, j].CompareTo(Convert.ChangeType(zero, typeof(T))) == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                output.AppendFormat("{0}   ", matrix[i, j]);
            }
            output.AppendLine();
        }
        return output.ToString();
    }


}