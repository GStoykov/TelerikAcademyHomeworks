using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten :Cat
    {
        public Kitten(string name, Sex sex, byte age)
            : base(name, Sex.female, age)
        {
        }
    }
}
