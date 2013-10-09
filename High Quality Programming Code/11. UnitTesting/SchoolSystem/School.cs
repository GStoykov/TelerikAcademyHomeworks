using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
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
                    throw new ArgumentNullException("School`s name is required.");
                }
                name = value;
            }
        }
        
        public List<Course> ListOfCourses { get; set; }

        public School(string name)
        {
            this.Name = name;
            this.ListOfCourses = new List<Course>();
        }

        public void AddCourse(Course newCourse)
        {
            this.ListOfCourses.Add(newCourse);
        }

        public void RemoveCourse(Course course)
        {
            if (IsCourseInTheSchool(course) == false)
            {
                throw new MissingMemberException("There is no such course.");
            }
            this.ListOfCourses.Remove(course);
        }

        private bool IsCourseInTheSchool(Course course)
        {
            for (int i = 0; i < ListOfCourses.Count; i++)
            {
                if (course.Name == ListOfCourses[i].Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
