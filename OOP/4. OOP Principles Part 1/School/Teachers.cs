using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Teachers : Human, ICommentable
    {
        // Fields
        private List<Disciplines> teachersDisciplines;
        private List<string> comments;

        // Properties
        public Disciplines[] Disciplines
        {
            get
            {
                return this.teachersDisciplines.ToArray();
            }
            private set { }
        }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            private set { }
        }

        // Constructors
        public Teachers(string name, List<Disciplines> teachersDisciplines)
            : base(name)
        {
            this.teachersDisciplines = new List<Disciplines>(teachersDisciplines);
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

        public void AddDiscipline(Disciplines newDiscipline)
        {
            this.teachersDisciplines.Add(newDiscipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.teachersDisciplines.Remove(discipline);
        }

    }
}
