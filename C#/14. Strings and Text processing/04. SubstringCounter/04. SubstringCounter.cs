using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubstringCounter
{
    static void Main()
    {
        // Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
        // Example: The target substring is "in". The result must be 9

        /*   We are living in an yellow submarine. We don't have anything else.
             Inside the submarine is very tight. So we are drinking all the day.
             We will move out of it in 5 days.                                    */

        string targetSubstr = "in";
        int substringCounter = 1;
        string text = @"We are living in an yellow submarine. We don't have anything else.
             Inside the submarine is very tight. So we are drinking all the day.
             We will move out of it in 5 days.";

        for (int i = 0; i < text.Length - 1; i++)
        {            
                if (text.Substring(i, 2) == targetSubstr)
                {
                    substringCounter++;
                }                
        }
        Console.WriteLine(substringCounter);
    }
}
