using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Student(string fName, string lName, int age)
    {
        this.FirstName = fName;
        this.LastName = lName;
        this.Age = age;
    }

    public Student(string fName, string lName)
        : this(fName, lName, 0)
    {
    }
}

