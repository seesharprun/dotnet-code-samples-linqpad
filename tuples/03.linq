<Query Kind="Program" />

void Main()
{
	var (first, last, books) = GetLibraryInfo();
	
	string libraryName = $"{last}, {first}";
	
	libraryName.Dump();
}

private (string, string, int) GetLibraryInfo()
{
	return ("Sidney", "Andrews", 125);
}