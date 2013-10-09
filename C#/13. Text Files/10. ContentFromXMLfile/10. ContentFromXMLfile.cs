using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10.ContentFromXMLfile
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("file.xml");
            using (reader)
            {
                int symbol = reader.Read();
                while ((symbol = reader.Read()) != -1)
                {
                    if (symbol == '>')
                    {
                        string content = "";
                        while ((symbol = reader.Read()) != -1 && symbol != '<')
                        {
                            content += (char)symbol;
                        }
                        if (!String.IsNullOrWhiteSpace(content))
                        {
                            Console.WriteLine(content);
                        }
                    }
                }
            }

        }
    }
}
