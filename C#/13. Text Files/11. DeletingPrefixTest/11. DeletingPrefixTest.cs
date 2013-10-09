using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Write a program that deletes from a text file all words that start with the prefix "test".
        // Words contain only the symbols 0...9, a...z, A…Z, _.
        StreamReader reader = new StreamReader("file.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter("newFile.txt");
            using (writer)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                }
            }
        }
    }
}
