using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string firstName;

        public string  FirstName
        {
            get 
            {
                return firstName;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student`s first name is requiered.");
                }
                firstName = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get 
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student`s last name is requiered.");
                }
                lastName = value;
            }
        }

        private int id;

        public int ID
        {
            get 
            {
                return id;
            }
            set 
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Student`s unique number must be between 10 000 and 99 999.");
                }
                id = value;
            }
        }

        public Student(string firstName, string lastName, int id) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

    }
}
