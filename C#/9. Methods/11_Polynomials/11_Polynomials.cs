using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polynomials
{
    class Polynomials
    {
        static void SumPolynomialMethod(int[] firstPol, int[] secondPol, int[] newPolynomial)
        {
            bool firstPolBigger = true;
            int minLenght = 0;

            if (firstPol.Length > secondPol.Length)
            {
                minLenght = secondPol.Length;
            }
            else
            {
                minLenght = firstPol.Length;
                firstPolBigger = false;
            }

            for (int i = 0; i < minLenght; i++)
            {
                newPolynomial[i] = firstPol[i] + secondPol[i];
            }

            for (int i = minLenght; i < newPolynomial.Length; i++)
            {
                if (firstPolBigger)
                {
                    newPolynomial[i] = firstPol[i];
                }
                else
                {
                    newPolynomial[i] = secondPol[i];
                }
            }
            Console.Write("Sum: \t\t\t\t");
            PrintPolynomial(newPolynomial);
            Console.WriteLine();
        }

        static void SubtractionPolynomialMethod(int[] firstPol, int[] secondPol, int[] newPolynomial)
        {
            bool firstPolBigger = true;
            int minLength = 0;

            if (firstPol.Length > secondPol.Length)
            {
                minLength = secondPol.Length;
            }
            else
            {
                minLength = firstPol.Length;
                firstPolBigger = false;
            }

            for (int i = 0; i < minLength; i++)
            {
                newPolynomial[i] = firstPol[i] - secondPol[i];
            }

            for (int i = minLength; i < newPolynomial.Length; i++)
            {
                if (firstPolBigger)
                {
                    newPolynomial[i] = firstPol[i];
                }
                else
                {
                    newPolynomial[i] = secondPol[i];
                }
            }

            Console.Write("Subtraction: \t\t\t");
            PrintPolynomial(newPolynomial);
            Console.WriteLine();
        }

        static void MultiplyPolynomialMethod(int[] firstPol, int[] secondPol, int[] newPolynomial)
        {

            for (int i = 0; i < firstPol.Length; i++)
            {
                for (int j = 0; j < secondPol.Length; j++)
                {
                    newPolynomial[i + j] += (firstPol[i] * secondPol[j]);
                }
            }
            Console.Write("Multiply: \t\t\t");
            PrintPolynomial(newPolynomial);
            Console.WriteLine();
        }


        static void PrintPolynomial(int[] polynomial)
        {
            for (int power = polynomial.Length - 1; power >= 0; power--)
			{
                if (polynomial[power] != 0 && power != 0)
                {
                    if (polynomial[power - 1] > 0)
                    {
                        Console.Write("{0}x^{1} +", polynomial[power], power);
                    }
                    else if (polynomial[power - 1] == 0)
                    {
                        Console.Write("{0}x^{1} ", polynomial[power], power);
                    }
                    else
                    {
                        Console.Write("{0}x^{1} ", polynomial[power], power);
                    }
                }
                else if (power == 0 && polynomial[0] != 0)
                {
                    Console.Write("{0}", polynomial[power]);
                }
			}
        }

        static void Main()
        {
            // Printing the polynomials
            int[] firstPol = { 0, -1, 5};
            Console.Write("First  polynomial: \t\t");
            PrintPolynomial(firstPol);
            Console.WriteLine();

            int[] secondPol = { 3, 2, 5, 4  };
            Console.Write("Second polynomial: \t\t");
            PrintPolynomial(secondPol);
            Console.WriteLine();
            Console.WriteLine();

            // Getting length for the result`s array
            int maxLength = firstPol.Length;
            if (firstPol.Length < secondPol.Length )
            {
                maxLength= secondPol.Length;
            }

            int[] newPolynomial = new int[maxLength];

            // Calling Sum Method
            SumPolynomialMethod(firstPol, secondPol, newPolynomial);
            Console.WriteLine();

            // Calling Subtraction method 
            SubtractionPolynomialMethod(firstPol, secondPol, newPolynomial);
            Console.WriteLine();

            // Calling Multiply Method
            int[] multiplyArr = new int[firstPol.Length + secondPol.Length];
            MultiplyPolynomialMethod(firstPol, secondPol, multiplyArr);
            Console.WriteLine();
        }
        
    }
}
