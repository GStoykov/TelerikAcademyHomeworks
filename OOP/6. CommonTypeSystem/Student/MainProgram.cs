using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainProgram
{
    static void Main()
    {
        Student student1 = new Student("Georgi", "Petrov", "12345", "0999999999", Specialty.ArtificialIntelligence);
        Student student2 = new Student("Nikolai", "Atanasov", "21345", "0888888888", Specialty.Combinatorics);

        if (student1 == student2)
        {
            Console.WriteLine("Students are equel.");
        }
        else
        {
            Console.WriteLine("Students are not equel.");
        }
        Console.WriteLine();

        // Clone
        Student studentClone = student1.Clone();
        Console.WriteLine(studentClone);
        studentClone.FirstName = "Mariika";
        Console.WriteLine();
        Console.WriteLine(student1.FirstName);
        Console.WriteLine(studentClone.FirstName);
        Console.WriteLine();

        // CompareTo() - result = -1 (Georgi < Nikolai)
        if (student1.CompareTo(student2) >= 0)
        {
            Console.WriteLine("Georgi");
        }
        else
        {
            Console.WriteLine("Nikolai");
        }

    }
}
