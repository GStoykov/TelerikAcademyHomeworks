using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        char[] arr = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                      'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        foreach (var letter in word)
        {
            Console.Write("Index of \"{0}\" is: ", letter);
            for (int i = 0; i < 26; i++)
            {
                if (letter == arr[i])
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine();
        }

    }
}
