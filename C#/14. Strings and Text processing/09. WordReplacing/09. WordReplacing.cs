using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordReplacing
{
    static void Main(string[] args)
    {
        string[] wordForReplacing = { "PHP", "CLR", "Microsoft" };
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        if (text.Contains("PHP"))
        {
            text = text.Replace(wordForReplacing[0], "***");
        }
        if (text.Contains("Microsoft"))
        {
            text = text.Replace(wordForReplacing[2], "*********");
        }
        if (text.Contains("CLR"))
        {
            text = text.Replace(wordForReplacing[1], "***");
        }
        Console.WriteLine(text);
        
    
    
    }
}