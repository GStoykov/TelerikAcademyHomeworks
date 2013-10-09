using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractingSentences
{
    static void Main()
    {
        string word = "in";
        string text = @"We are living in a yellow submarine.We don't have anything else.Inside the submarine is very tight.So we are drinking all the day.We will move out of it in 5 days.";

        string[] sentences = text.Split('.');

        foreach (var sentence in sentences)
        {
            if (sentence.Contains(" in "))
            {
                Console.WriteLine(sentence + ".");
            }
        }

    }
}
