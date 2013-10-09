using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08_AddingNumeralStrings
{
    class Program
    {
        static void Main(string[] args)
        {
        //    // Write a method that adds two positive integer numbers represented as arrays of digits 
        //    // (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        //    // Each of the numbers that will be added could have up to 10 000 digits.

        //    Console.Write("Enter first number: ");
        //    BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
        //    Console.Write("Enter second number: ");
        //    BigInteger secondNumber = BigInteger.Parse(Console.ReadLine());
            
        //    string arr1 = firstNumber.ToString(); 
        //    string arr2 = secondNumber.ToString();

        //    int loopRange;
        //    if (arr1.Length > arr2.Length)
        //    {
        //        loopRange = arr2.Length;
        //    }
        //    else
        //    {
        //        loopRange = arr1.Length;
        //    }
        //    List<char> newNumber = new List<char>();
        //    bool carry = true;
        //    for (int i = loopRange - 1; i >= 0; i--)
        //    {
        //        newNumber.Add(newDigit(i, arr1, arr2, carry));
        //    }

        //}

        //static char newDigit(int i, string arr1, string arr2, bool carry)
        //{
        //    int charNumber;
        //    if (arr1.Length == arr2.Length)
        //    {
        //        if (carry)
        //        {
        //            charNumber = arr1[i] + arr2[i] + '1';
        //            SwitchMetod(charNumber);
        //        }
        //        else
        //        {
        //            charNumber = arr1[i] + arr2[i];
        //            SwitchMetod(charNumber);           
        //        }
        //    }
        //    else
        //    {
        //        if (carry)
        //        {
        //            charNumber = arr1[i] + arr2[i] + '1';
        //            SwitchMetod(charNumber);
        //        }
        //        else
        //        {
        //            charNumber = arr1[i] + arr2[i];
        //            SwitchMetod(charNumber);
        //        }
        //    }
            
        //}

        //static char SwitchMetod(int charNumber)
        //{
        //    switch (charNumber)
        //    {
        //        case 96: return '0'; break;
        //        case 97: return '1'; break;
        //        case 98: return '2'; break;
        //        case 99: return '3'; break;
        //        case 100: return '4'; break;
        //        case 101: return '5'; break;
        //        case 102: return '6'; break;
        //        case 103: return '7'; break;
        //        case 104: return '8'; break;
        //        case 105: return '9'; break;
        //        case 145: return '1'; break;
        //        case 146: return '2'; break;
        //        case 147: return '3'; break;
        //        case 148: return '4'; break;
        //        case 149: return '5'; break;
        //        case 150: return '6'; break;
        //        case 151: return '7'; break;
        //        case 152: return '8'; break;
        //        default: return '9'; break;                    
        //    }
        }
    }
}
