﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        
        public OffsiteCourse(string name)
            : this(name, null)
        {
        }

       
        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, teacherName, null)
        {
        }

        
        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName, students, null)
        {
        }

        
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

       
        public string Town { get; set; }

       
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("Offsite{0}", base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
