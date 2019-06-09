using System;
namespace ObserverPattern.Old.Notifier
{
    public class YoutubeNotifier : INotifier
    {
        public void Notify(string name, string description, string fileName)
        {
            Console.WriteLine(
                string.Format($"Notify all subscribers via YOUTUBE with new data" +
            	                "\n\tName: {0}" +
                                "\n\tDescription: {1}" +
                                "\n\tFile name: {2}",
                                name, description, fileName));
        }
    }
}
