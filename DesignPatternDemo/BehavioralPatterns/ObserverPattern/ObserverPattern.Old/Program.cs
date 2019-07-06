using System;

namespace ObserverPattern.Old
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();

            videoData.SetTitle("Observer Design Pattern: Analyze");

            Console.WriteLine("\nUpdated video data!\n");

            videoData.SetDescription("New Description");
        }
    }
}
