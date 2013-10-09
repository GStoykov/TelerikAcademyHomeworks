using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class PringOddLines
{
    static void Main(string[] args)
    {
        // Write a program that reads a text file and prints on the console its odd lines.


        StreamReader reader = new StreamReader("numbers.txt");
        using (reader)
        {
            int lineCounter = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineCounter % 2 == 1 )
                {
                    Console.WriteLine(line);    
                }
                line = reader.ReadLine();
                lineCounter++;                
            }
        }

    }
}