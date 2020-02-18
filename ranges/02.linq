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

phonetic[12..19].Dump("N - T");

phonetic[0..5].Dump("A - E");

phonetic[20..25].Dump("V - Z");