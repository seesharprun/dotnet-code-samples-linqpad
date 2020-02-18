<Query Kind="Program" />

void Main()
{
	var (duration, video, audio) = GetVideoInfo();
	
	video.Dump();
}

private (TimeSpan duration, string videoCodec, string audioCodec) GetVideoInfo()
{
	// Heavy-duty logic
	return (TimeSpan.FromSeconds(15.25), "H.264", "PCM");
}
