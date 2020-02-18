<Query Kind="Program" />

void Main()
{
	string name = "Peter";
	double gpa = 3.5;
	var student = (name, gpa);

	string accolades = student switch
	{
		var s when s.gpa >= 4.0 => "Scholar Roll",
		var s when s.gpa >= 3.0 && s.gpa < 4.0 => "Honor Roll",
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
