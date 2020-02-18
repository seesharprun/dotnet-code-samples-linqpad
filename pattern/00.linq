<Query Kind="Statements">
  <Namespace>System.Drawing</Namespace>
</Query>

var wallColor = KnownColor.Blue;

switch(wallColor)
{
	case KnownColor.Red:
		"Red Wall".Dump();
		break;
	case KnownColor.Green:
		"Green Wall".Dump();
		break;
	case KnownColor.Yellow:
		"Yellow Wall".Dump();
		break;
	default:
		"Unknown Wall".Dump();
		break;
}