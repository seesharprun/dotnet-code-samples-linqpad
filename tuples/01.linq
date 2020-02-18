<Query Kind="Program" />

void Main()
{
	(string, string, int) name = GetLibraryInfo();
	
	string libraryName = $"{name.Item2}, {name.Item1}";
	
	libraryName.Dump();
}

private (string, string, int) GetLibraryInfo()
{
	return ("Sidney", "Andrews", 125);
}