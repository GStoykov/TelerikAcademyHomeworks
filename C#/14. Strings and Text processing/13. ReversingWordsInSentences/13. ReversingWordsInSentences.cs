using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReversingWordsInSentences
{
    static void Main()
    {
        // Write a program that reverses the words in given sentence.
	    // Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

        string text = "C# is not C++, not PHP and not Delphi!";

        string[] word = text.Split(' ', '.', '!', '?');
       
        Console.WriteLine(text);
        for (int i = word.Length - 2; i >= 1; i--)
        {
            Console.Write(word[i] + " ");    
        }
        Console.Write(word[0]);
        Console.Write(text[text.Length - 1]);
        Console.WriteLine();

    }
}
