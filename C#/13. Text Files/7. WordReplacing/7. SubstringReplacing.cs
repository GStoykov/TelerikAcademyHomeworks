using System;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
        // Ensure it will work with large files (e.g. 100 MB).

        StreamReader reader = new StreamReader("Text.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter("ReplacedText.txt");
            using (writer)
            {
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                }
            }
        }
    }
}