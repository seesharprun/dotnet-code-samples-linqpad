<Query Kind="Statements">
  <Namespace>System.Drawing</Namespace>
</Query>

var color = KnownColor.Blue;

string wallColor = color switch
{
	KnownColor.Red => "Red Wall",
	KnownColor.Green => "Green Wall",
	KnownColor.Yellow => "Yellow Wall",
	_ => "Unknown Wall"
};

wallColor.Dump();