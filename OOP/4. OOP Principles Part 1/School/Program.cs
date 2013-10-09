using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main()
        {
            Student first = new Student("Gosho", "1");
            Student second = new Student("Ivan", "2");
            Student[] studentGroup = { first, second };
            Disciplines algebra = new Disciplines("Algebra", 5, 5);

            Teachers teacher = new Teachers("Kanev", new List<Disciplines> {algebra});
            Teachers[] teacherGroup = { teacher };
            Classes math = new Classes(studentGroup.ToList(), teacherGroup.ToList(), "Math Class");

            Console.Write("Class: ");
            Console.WriteLine(math.ID);
            Console.Write("Discipline: ");
            Console.WriteLine(algebra.Name);
            Console.Write("Teacher: ");
            Console.WriteLine(teacher.Name);
            Console.Write("Best student: ");
            Console.WriteLine(math.Students[0].Name);

            Console.WriteLine("\nComments: ");
            math.AddComment("algebra");
            math.AddComment("geometry");
            foreach (var item in math.Comments)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\nAfter algebra is removed: ");
            math.RemoveComment("algebra");
            foreach (var item in math.Comments)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }
}
