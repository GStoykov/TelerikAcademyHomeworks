using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Student : Human, ICommentable
    {
        // Fields
        private string unicID;
        private List<string> comments;

        // Properties
        public string UnicID
        {
            get
            {
                return this.unicID;
            }
            set
            {
                this.unicID = value;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            private set { }
        }

        // Constructor
        public Student(string name, string unicID) :base(name)
        {
            this.unicID = unicID;
            this.comments = new List<string>();
        }

        // Methods
        public void AddComment(string comment)
        {
            comments.Add(comment);
        }

        public void RemoveComment(string comment)
        {
            comments.Remove(comment);
        }
    }
}
