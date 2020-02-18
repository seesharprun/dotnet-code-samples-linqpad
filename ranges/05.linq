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

Range start_to_m = ..13;

phonetic[start_to_m].Dump("<- N");

Range n_to_end = ^13..;

phonetic[n_to_end].Dump("N ->");
