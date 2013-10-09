using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class String_WithTwentyChars
{
    static void Main(string[] args)
    {
       // Write a program that reads from the console a string of maximum 20 characters. 
       // If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
       // Print the result string into the console.
        string str = "";
        do
        {
            Console.Write("Enter a string (max 20 chars) = ");
            str = Console.ReadLine();
        } while (str.Length > 20);

        if (str.Length == 20)
        {
            Console.WriteLine(str);
        }
        else
        {
            StringBuilder newStr = new StringBuilder();
            newStr.Append(str);
            for (int i = 0; i < 20 - str.Length; i++)
            {
                newStr.Append("*");
            }
            Console.WriteLine(newStr);
        }

    }
}
