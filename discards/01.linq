<Query Kind="Program" />

void Main()
{
	var (_, codec, _) = GetVideoInfo();
	
	codec.Dump();
}

private (TimeSpan duration, string videoCodec, string audioCodec) GetVideoInfo()
{
	// Heavy-duty logic
	return (TimeSpan.FromSeconds(15.25), "H.264", "PCM");
}