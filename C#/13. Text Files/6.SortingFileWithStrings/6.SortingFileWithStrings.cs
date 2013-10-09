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
        List<string> lineWithName = new List<string>();
        StreamReader reader = new StreamReader("Names.txt");
        using (reader)
        {
            string name;
            while ((name = reader.ReadLine()) != null)
            {
                lineWithName.Add(name);
            }
        }

        lineWithName.Sort();

        StreamWriter sortedNames = new StreamWriter("SortedNames.txt");
        using (sortedNames)
        {
            foreach (var name in lineWithName)
            {
                sortedNames.WriteLine(name);
            }
        }

    }
}
    //static List<string> ReadLines()
    //{
    //    List<string> lines = new List<string>();

    //    using (StreamReader input = new StreamReader("Names.txt"))
    //        for (string line; (line = input.ReadLine()) != null; )
    //            lines.Add(line);

    //    return lines;
    //}

    //static void WriteLines(List<string> lines)
    //{
    //    using (StreamWriter output = new StreamWriter("New.txt"))
    //        foreach (string line in lines)
    //            output.WriteLine(line);
    //}

    //static void Main()
    //{
    //    List<string> lines = ReadLines(); // File.ReadAllLines

    //    lines.Sort();

    //    WriteLines(lines); // File.WriteAllLines
    //}

