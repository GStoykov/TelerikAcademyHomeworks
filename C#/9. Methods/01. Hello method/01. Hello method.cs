using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
        // Write a program to test this method.
        Console.Write("What`s your name: ");
        string name = Console.ReadLine();
        Print(name);
    }

    private static void Print(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    
}