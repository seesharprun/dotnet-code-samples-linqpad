<Query Kind="Program" />

void Main()
{
	Student student = new Student("Peter");

	double mathGrade = student switch
	{
		{ Name: "Alex" } => 90,
		{ Name: "Susan" } => 80,
		{ Name: "Peter" } => 70,
		_ => throw new ArgumentException(nameof(student))
	};
	
	mathGrade.Dump();
}

public class Student
{
	public Student(string name) => Name = name;
	
	public string Name { get; }
	
	public double GPA { get; set; }
}
