using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertToUnicode
{
    static void Main()
    {
        // Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
        // Example:  Hi! ---> \u0048\u0069\u0021

        string text = "Hi!";
        foreach (var symbol in text)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine();
    }
}