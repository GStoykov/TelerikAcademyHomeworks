using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        Person gosho = new Person("Gosho", 21);
        Person mitko = new Person("Mitko");
        
        Console.WriteLine(gosho);
        Console.WriteLine();
        Console.WriteLine(mitko);
    }
}