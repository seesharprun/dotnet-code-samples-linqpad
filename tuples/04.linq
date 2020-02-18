<Query Kind="Statements" />

string first = "Sidney";

string last = "Andrews";

int books = 125;

var name = (first, last, books);

string libraryName = $"{name.last}, {name.first}";

libraryName.Dump();