<Query Kind="Program" />

void Main()
{
	Student student = new Student("Peter") { GPA = 3.5 };

	string accolades = student switch
	{
		var s when s.GPA >= 4.0 => "Scholar Roll",
		var s when s.GPA >= 3.0 && s.GPA < 4.0 => "Honor Roll",
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
