using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Human
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Human(string name)
        {
            this.name = name;
        }
    }
}
