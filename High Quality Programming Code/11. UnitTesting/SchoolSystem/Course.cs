using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        public const byte MaxStudentsInCourse = 29;

        private string name;

        public string Name
        {
            get 
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course`s name is requiered.");
                }
                name = value;
            }
        }

        public List<Student> ListOfStudents { get; set; }

        public Course(string name)
        {
            this.Name = name;
            this.ListOfStudents = new List<Student>();
        }

        public void AddStudent(Student newStudent)
        {
            if (ListOfStudents.Count >= MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("The course is full.");
            }
            if (isStudentInTheCourse(newStudent))
            {
                throw new ArgumentException("The student is in the course already.");
            }

            this.ListOfStudents.Add(newStudent);
        }

        public void RemoveStudent(Student student)
        {
            if (isStudentInTheCourse(student) == false)
            {
                throw new MissingMemberException("There is no such student");
            }

            this.ListOfStudents.Remove(student);
        }

        private bool isStudentInTheCourse(Student student)
        {
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                if (student.ID == ListOfStudents[i].ID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
