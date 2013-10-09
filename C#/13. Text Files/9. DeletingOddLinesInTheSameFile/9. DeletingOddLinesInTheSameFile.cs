using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that deletes from given text file all odd lines. The result should be in the same file.

        List<string> evenLines = new List<string>();
        StreamReader reader = new StreamReader("Numbers.txt");
        using (reader)
        {
            string line;
            int lineCounter = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (lineCounter % 2 == 0)
                {
                    evenLines.Add(line);
                }
                lineCounter++;
            }
        }
        StreamWriter writer = new StreamWriter("Numbers.txt");
        using (writer)
        {
            for (int i = 0; i < evenLines.Count; i++)
            {
                writer.WriteLine(evenLines[i]);
            }
        }

    }
}