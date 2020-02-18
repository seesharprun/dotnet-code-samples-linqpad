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

phonetic[20..].Dump("V ->");

phonetic[..7].Dump("<- G");