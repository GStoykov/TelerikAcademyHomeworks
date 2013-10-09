using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Classes : ICommentable
    {
        // Fields
        private List<Student> listOfStudents;
        private List<Teachers> listOfTeachers;
        private string id;
        private List<string> comments;

        // Properties
        public List<Teachers> Teachers
        {
            get
            {
                return this.listOfTeachers;
            }
            private set { }
        }

        public List<Student> Students
        {
            get
            {
                return this.listOfStudents;
            }
            private set { }
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            set { }
        }

        // Constructors
        public Classes(List<Student> listOfStudents, List<Teachers> listOfTeachers, string id, List<string> comments)
        {
            this.listOfStudents = listOfStudents;
            this.listOfTeachers = listOfTeachers;
            this.id = id;
            this.comments = new List<string>();
        }

        public Classes(List<Student> listOfStudents, List<Teachers> listOfTeachers, string id) 
            :this(listOfStudents, listOfTeachers, id, null)
        {
        }

                     // METHODS

        // Methods about students
        public void AddStudent(Student newStudent)
        {
            this.listOfStudents.Add(newStudent);
        }

        public void RemoveStudent(Student targetedStudent)
        {
            this.listOfStudents.Remove(targetedStudent);
        }

        // Methods about teachers
        public void AddTeacher(Teachers newTeacher)
        {
            this.listOfTeachers.Add(newTeacher);
        }

        public void RemoveTeacher(Teachers targetedTeacher)
        {
            this.listOfTeachers.Remove(targetedTeacher);
        }

        // Methods about comments
        public void AddComment(string newComment)
        {
            this.comments.Add(newComment);
        }

        public void RemoveComment(string targetedComment)
        {
            this.comments.Remove(targetedComment);
        }
    }
}
