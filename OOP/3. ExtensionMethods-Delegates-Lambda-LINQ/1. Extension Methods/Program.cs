using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Substring Method test 
        StringBuilder text = new StringBuilder();
        text.Append("1234567890");
        Console.WriteLine("StringBuilder`s Substring method: {0}", text.Substring(0, 3));

        string test = "1234567890";
        Console.WriteLine("Strings`s Substring method: {0}", test.Substring(0, 3));
        Console.WriteLine();

    }
}
