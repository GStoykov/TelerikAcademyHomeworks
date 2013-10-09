using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.MyAgePlusTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            string a = Console.ReadLine();
            int age;
            int.TryParse(a, out age);
            Console.WriteLine("Your age in 10 years will be {0}.",age+10);
        }
    }
}
