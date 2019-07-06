using ObserverPattern.New.Notifiers;
using System;

namespace ObserverPattern.New
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();
            _ = new EmailNotifier(videoData);
            _ = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer Design Pattern");

            videoData.DetachObserver(youtubeNotifier);
            Console.WriteLine("-------------------------------");
            videoData.SetDescription("Ongdev's video");

            _ = new FacebookNotifier(videoData);
            Console.WriteLine("-------------------------------");
            videoData.SetFileName("A very good tutorial");

            Console.ReadKey();
        }
    }
}
