using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Specialty
{
    ArtificialIntelligence = 1,
    Combinatorics = 2,
    CondensedMatter = 3,
    Microbiology = 4,
}

public enum Faculty
{
    ComputerSciences = 1, Math = 2, BiologicalSciences = 3,
}

public enum University
{
    MIT = 1, Harvard = 2, Cambridge = 3,
}

public class Student : ICloneable, IComparable<Student>
{
    // TASK 1

    // Properties
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string SSN { get; protected set; }
    public string Adress { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public byte Course { get; set; }
    public Specialty Speciality { get; set; }
    public Faculty Faculty { get; protected set; }
    public University University { get; set; }

    // Constructors
    public Student(string firstName, string middleName, string lastName, string ssn,
        string adress, string mobile, string email, byte course, Specialty speciality,
        Faculty faculty, University university )
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Adress = adress;
        this.Mobile = mobile;
        this.Email = email;
        this.Course = course;
        this.Speciality = speciality;
        this.Faculty = faculty;
        this.University = university;
    }

    public Student(string firstName, string lastName, string ssn, string mobile, Specialty speciality) 
        :this(firstName, null, lastName, ssn,null, mobile, null, 1, speciality, Faculty.ComputerSciences , University.MIT)
    {
    }


    // Override methods
    public override bool Equals(object obj)
    {
        // If the cast is invalid, the result will be null
        Student student = obj as Student;
        // Check if we have valid not null Student object
        if (student == null)
            return false;
        // Compare the reference type member fields
        if (!Object.Equals(this.SSN, student.SSN))
            return false;
        return true;
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.Append("Student: ");
        text.AppendFormat("\nName: {0} {1}", this.FirstName, this.LastName);
        text.AppendFormat("\nSSN: {0} \nMobile: {1}", this.SSN, this.Mobile);
        text.AppendFormat("\nSpeciality: {0}", this.Speciality);
        return text.ToString();
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1.SSN, student2.SSN);
    }
    public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1.SSN, student2.SSN));
    }

    // TASK 2
    public Student Clone()
    {
        return new Student(this.FirstName, this.MiddleName , this.LastName,
                                        this.SSN, this.Adress, this.Mobile, this.Email,
                                        this.Course, this.Speciality, this.Faculty, this.University );
    }

    object ICloneable.Clone()
    {
        return this.Clone();
    }


    public int CompareTo(Student other)
    {
        if (this.FirstName != other.FirstName)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }
        if (this.MiddleName != other.MiddleName)
        {
            return this.MiddleName.CompareTo(other.MiddleName);
        }
        if (this.LastName != other.LastName)
        {
            return this.LastName.CompareTo(other.LastName);
        }
        if (this.SSN != other.SSN)
        {
            return this.SSN.CompareTo(other.SSN);
        }
        return 0;
    }
}

