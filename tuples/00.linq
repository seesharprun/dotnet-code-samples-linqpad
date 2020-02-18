<Query Kind="Program" />

void Main()
{
	Tuple<string, string, int> name = GetLibraryInfo();
	
	string libraryName = $"{name.Item2}, {name.Item1}";
	
	libraryName.Dump();	
}

private Tuple<string, string, int> GetLibraryInfo()
{
	return new Tuple<string, string, int>("Sidney", "Andrews", 125);
}
