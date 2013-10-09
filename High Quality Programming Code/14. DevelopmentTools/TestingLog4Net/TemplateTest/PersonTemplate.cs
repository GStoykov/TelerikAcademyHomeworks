using System;

public class Person
{
	public string firstName { get; set; }
	public string lastName { get; set; }
	public byte Age { get; set; }

	public Person(string fName, string lName, byte age)
	{
		this.firstName = fName;
		this.lastName = lName;
		this.Age = age;
	}
	
}