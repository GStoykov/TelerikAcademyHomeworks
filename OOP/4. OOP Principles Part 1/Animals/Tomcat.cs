using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat :Cat
    {
        public Tomcat(string name, Sex sex, byte age)
            : base(name, Sex.male, age)
        {
        }
    }
}
