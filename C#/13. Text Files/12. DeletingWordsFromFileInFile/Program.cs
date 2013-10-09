using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.DeletingWordsFromFileInFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string wordsForDeleting = @"\b(" + String.Join("|", File.ReadAllLines("words.txt")) + @")\b";

            StreamReader reader = new StreamReader("file.txt");
            using (reader)
            {
                StreamWriter writer = new StreamWriter("newFile.txt");
                using (writer)
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(Regex.Replace(line, wordsForDeleting, String.Empty));
                    }
                }
            }
        }
    }
}
