using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{

    public abstract class Course
    {
        private string name;


        protected Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course`s name shouldn`t be empty!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("Course { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }

    }
}
