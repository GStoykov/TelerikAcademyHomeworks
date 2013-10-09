using System;
using System.Text.RegularExpressions;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("Text.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter("ReplacedText.txt");
            using (writer)
            {
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(Regex.Replace(line ,"start", "finish"));
                }
            }
        }
    }
}