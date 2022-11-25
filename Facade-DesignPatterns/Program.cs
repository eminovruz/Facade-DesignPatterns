#nullable disable

static public class VideoDownloader
{
    static private VideoFormatFinder _format = new();
    static private QualityFinder _qualify = new();
    static private LinkFinder _link = new();


    static public void Start()
    {
        _link.FindLink();
        _qualify.FindIdealQuality();
        _format.FindIdealFormat();
        Console.WriteLine("Final Video: ");
        Console.WriteLine(_link.Link);
        Console.WriteLine(_qualify.Quality);
        Console.WriteLine(_format.VideoFormat);
    }
}

class VideoFormatFinder
{
    public string VideoFormat { get; set; }

    public void FindIdealFormat()
    {
        
        Console.WriteLine("Select Format: ");
        Console.WriteLine(" -- mp4 ");
        Console.WriteLine(" -- mp3 ");
        Console.WriteLine(" -- video ");
        VideoFormat = Console.ReadLine();
    }
}

class QualityFinder
{
    public int Quality { get; set; }

    public void FindIdealQuality()
    {
        Console.WriteLine("Select Quality: ");
        Quality = Int32.Parse(Console.ReadLine());
    }
}

class LinkFinder
{
    public string Link { get; set; }

    public void FindLink()
    {
        Console.WriteLine("Paste link: ");
        Link = Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        VideoDownloader.Start();
    }
}
