using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reversing_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i > -1 ; i--)
            {
                result.Append(str[i]);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
