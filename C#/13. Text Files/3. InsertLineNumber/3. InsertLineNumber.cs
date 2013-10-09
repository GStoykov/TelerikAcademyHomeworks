using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.InsertLineNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("letters.txt");
            using (reader)
            {
                int lineCounter = 1;
                string line;
                StreamWriter writer = new StreamWriter("NumberedLines.txt");
                using (writer)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.Write("{0}. ", lineCounter);
                        writer.WriteLine(line);
                        lineCounter++;
                    }

                }

            }
        }
    }
}
