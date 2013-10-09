using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public enum Sex
    {
        male = 1,
        female = 2,
    }

    public class Animals
    {
        // Fields and Properties
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Sex sex;

        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private byte age;

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        public Animals(string name, Sex sex, byte age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public Animals()
        {            
        }


        public static double AverageAge(Animals[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("There is no data for such animals");
            }
            else if (array.Length == 1)
            {
                return array[0].Age;
            }

            double sum = 0;
            foreach (var animal in array)
            {
                sum += animal.age;
            }

            return sum / array.Length;
        }

    }
}
