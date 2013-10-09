using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HumanType
{
    public enum Sex
    {
        Male, Female,
    }

    public class Human
    {
        public Sex Sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public void CreateHuman(int socialSecurityNumber)
    {
        Human newHuman = new Human();
        newHuman.Age = socialSecurityNumber;
        if (socialSecurityNumber % 2 == 0)
        {
            newHuman.Name = "Man";
            newHuman.Sex = Sex.Male;
        }
        else
        {
            newHuman.Name = "Woman";
            newHuman.Sex = Sex.Female;
        }
    }


}
