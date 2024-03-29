﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{

    public class LocalCourse : Course
    {
        public string Lab { get; set; }
        public LocalCourse(string name)
            : this(name, null)
        {
        }


        public LocalCourse(string courseName, string teacherName)
            : this(courseName, teacherName, null)
        {
        }


        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName, students, null)
        {
        }


        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }



        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("Local{0}", base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }

}
