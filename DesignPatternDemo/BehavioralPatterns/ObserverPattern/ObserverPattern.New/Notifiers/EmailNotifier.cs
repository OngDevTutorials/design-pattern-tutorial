using ObserverPattern.New.Base;
using System;

namespace ObserverPattern.New.Notifiers
{
    public class EmailNotifier : Observer
    {
        public EmailNotifier(Subject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
        }

        public override void Notify(object arg)
        {
            if(Subject is VideoData videoData)
            {
                    Console.WriteLine("Notify all subscribers via EMAIL with new data" +
                                      "\n\tName: {0}" +
                                      "\n\tDescription: {1}" +
                                      "\n\tFile name: {2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName());
            }
        }
    }
}
