﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Human
    {
        // Field and his property
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        // Constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }
    }
}
