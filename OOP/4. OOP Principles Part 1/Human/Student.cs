using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Student : Human
    {
        // Field and his property
        private uint grade;

        public uint Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        // Constructor
        public Student(string firstName, string lastName, uint grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }
        
    }
}
