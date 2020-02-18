<Query Kind="Program" />

void Main()
{
	var name = GetLibraryInfo();
	
	string libraryName = $"{name.last}, {name.first}";
	
	libraryName.Dump();
}

private (string first, string last, int books) GetLibraryInfo()
{
	return ("Sidney", "Andrews", 125);
}