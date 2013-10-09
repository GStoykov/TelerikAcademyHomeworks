using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animals
    {
        public Cat(string name, Sex sex, byte age)
            : base(name, sex, age)
        {
        }



        public string ProduceSound()
        {
            return "Meow";
        }
    }
}
