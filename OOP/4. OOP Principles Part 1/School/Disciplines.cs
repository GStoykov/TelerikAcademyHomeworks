using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Disciplines
    {
        // Fields
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;
        private List<string> comments;

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            private set 
            {
                this.name = value;
            }
        }

        public uint NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set 
            {
                this.numberOfLectures = value;
            }
        }

        public uint NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set 
            {
                this.numberOfExercises = value;
            }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            private set {}
        }

        // Constructor
        public Disciplines(string name, uint numberOfLectures, uint numberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }

        // Methoods
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
