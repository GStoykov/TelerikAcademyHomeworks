using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Write a method that returns the last digit of given integer as an English word.
        // Examples: 512 --> "two", 1024 --> "four", 12309 --> "nine".

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigitAsAnWord(number));
    }

    static string LastDigitAsAnWord(int number)
    {
        string digits = number.ToString();
        char lastDigit = digits[digits.Length - 1];
        switch (lastDigit)
        {
            case '1': digits = "One"; break;
            case '2': digits = "Two"; break;
            case '3': digits = "Three"; break;
            case '4': digits = "Four"; break;
            case '5': digits = "Five"; break;
            case '6': digits = "Six"; break;
            case '7': digits = "Seven"; break;
            case '8': digits = "Eight"; break;
            case '9': digits = "Nine"; break;
            default: digits = "Zero"; break;
        }
        return digits;
    }
}