using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private short? age;

    public string Name
    {
        get { return name; }
        set 
        {
            if (value == null)
            {
                throw new ArgumentNullException("You must enter a name!");
            }
            else if (value.Length < 2)
            {
                throw new ArgumentException("The name must contain at least two chars!");
            }
            name = value; 
        }
    }

    public short? Age
    {
        get { return age; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("The age must be positive!");
            }
            age = value; 
        }
    }
    
    // Constructors
    public Person(string name, byte? age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Person(string name)
        : this(name, null)
    {
    }

    public Person()
    {
    }

    // Methods
    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendFormat("Person's name: {0}. ", this.Name);
        if (this.Age == null)
        {
            text.AppendFormat("\n{0}'s age is unspecified.", this.Name);
        }
        else
        {
            text.AppendFormat("\n{0}'s age is {1}. ", this.Name,this.Age);
        }
        return text.ToString();
    }

}