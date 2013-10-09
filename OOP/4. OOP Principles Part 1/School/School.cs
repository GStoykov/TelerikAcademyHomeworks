using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School
    {
        //  The School is list of classes

        // Field
        private List<Classes> listOfClasses;

        // Property 
        public Classes[] Classes
        {
            get
            {
                return this.listOfClasses.ToArray();
            }
            private set { }
        }

        // Constructor
        public School(Classes[] classes)
        {
            this.listOfClasses = new List<Classes>(classes);
        }
        
        // Methods
        public void AddClass(Classes newClass)
        {
            this.listOfClasses.Add(newClass);
        }

        public void RemoveClass(Classes targetClass)
        {
            this.listOfClasses.Remove(targetClass);
        }
    }
}
