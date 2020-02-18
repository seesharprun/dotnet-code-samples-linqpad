<Query Kind="Program" />

void Main()
{
	Student student = new Student("Peter") { GPA = 4.0 };

	string accolades = student switch
	{
		{ GPA: 4.0 } => "Scholar Roll",
		{ GPA: 3.0 } => "Honor Roll",
		_ => String.Empty
	};
	
	accolades.Dump();
}

public class Student
{
	public Student(string name) => Name = name;
	
	public string Name { get; }
	
	public double GPA { get; set; }
}
