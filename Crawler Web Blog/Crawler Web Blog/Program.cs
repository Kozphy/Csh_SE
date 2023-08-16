using System.Net;

namespace Crawler_Web_Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targeturl = "https://example.com";
            Console.WriteLine("Hello, World!");
        }

        static void CrawlWebsite(string url)
        {
            WebClient webClient = new WebClient();
            string htmlContent = webClient.DownloadString(url);
            
            
        }
    }
}