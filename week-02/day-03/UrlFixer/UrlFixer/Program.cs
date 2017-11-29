using System;

namespace UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            url = url.Replace("bots", "odds");
            url = url.Insert(url.IndexOf("/"), ":");
            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
