using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dictionary
{
    static void Main()
    {
        // A dictionary is stored as a sequence of text lines containing words and their explanations. 
        // Write a program that enters a word and translates it by using the dictionary.
        string word = "CLR";
        string[] dictionary = {".NET – platform for applications from Microsoft",
                               "CLR – managed execution environment for .NET",
                               "namespace – hierarchical organization of classes" };
        
        Console.Write(word + " - ");
        for (int i = 0; i < dictionary.Length; i++)
        {
            string[] whichWord = dictionary[i].Split(' ');
            if (whichWord[0] == word)
            {
                for (int j = 2; j < whichWord.Length; j++)
                {
                    Console.Write(whichWord[j] + " ");
                }
            }
        }
        Console.WriteLine();
                              

    }
}