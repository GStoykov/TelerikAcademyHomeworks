using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.ConcatenateTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that concatenates two text files into another text file.
            StreamReader number = new StreamReader("numbers.txt");
            using(number)
	        {
                StreamWriter writer = new StreamWriter("file.txt");
                using (writer)
                {
                    string numLine;
                    while ((numLine = number.ReadLine()) != null)
                    {
                        writer.WriteLine(numLine);
                    }

                }
	        }

            StreamReader letter = new StreamReader("letters.txt");
            using (letter)
            {
                StreamWriter writer = new StreamWriter("file.txt", true);
                using (writer)
                {
                    string letterLine;
                    while ((letterLine = letter.ReadLine()) != null)
                    {
                        writer.WriteLine(letterLine);
                    }
                }
            }

            
        }
    }
}
