using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    //3. Write a method that from a given array of students finds all students
    //   whose first name is before its last name alphabetically. Use LINQ query operators.

    //4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    //5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort
    //   the students by first name and last name in descending order. Rewrite the same with LINQ.

    static void Main()
    {
        Student[] students = 
        {
            new Student("Georgi", "Petrov", 20),
            new Student("Elezar", "Angelov", 21),
            new Student("Ïvan", "Dimitrov", 15),
            new Student("Qna", "Novakova", 21),
        };

        // Task 3
        var firstNameBeforeLast =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;
        //Print(firstNameBeforeLast);

        // Task 4
        var from18to24 =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;
        //Print(from18to24);

        // Task 5
        //  Lambda 
        var descendingSortLambda = students.OrderByDescending
            (x => x.FirstName).ThenByDescending(x => x.LastName);
        //Print(descendingSortLambda);

        //  LINQ
        var descendingSortLINQ =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;
        //Print(descendingSortLINQ);
    }

    private static void Print(dynamic list)
    {
        Console.WriteLine("Sorting:");
        foreach (var item in list)
        {
            Console.WriteLine("First name: {0}, Last name: {1}, Age: {2}",
                item.FirstName, item.LastName, item.Age);
        }
    }
}

