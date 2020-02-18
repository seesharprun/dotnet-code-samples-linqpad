<Query Kind="Statements" />

string[] phonetic =
{
	"Alfa", "Bravo", "Charlie", "Delta",
	"Echo", "Foxtrot", "Golf", "Hotel",
	"India", "Juliett", "Kilo", "Lima",
	"November", "Oscar", "Papa", "Quebec",
	"Romeo", "Sierra", "Tango", "Uniform",
	"Victor", "Whisket", "X-Ray", "Yankee",
	"Zulu"
};

phonetic[^10..^2].Dump("Q - X");

phonetic[^7..].Dump("T ->");