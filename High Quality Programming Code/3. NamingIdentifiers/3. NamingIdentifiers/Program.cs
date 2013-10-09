using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    const int MAX = 6;
    
    public class Output
    {
        public void PrintBoolResultAsText(bool boolValue)
        {
            string output = boolValue.ToString();
            Console.WriteLine(output);
        }
    }

    static void Main()
    {
        Program.Output result = new Program.Output();
        result.PrintBoolResultAsText(true);
    }
}

