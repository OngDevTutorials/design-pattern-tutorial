using ObserverPattern.New.Base;
using System;

namespace ObserverPattern.New.Notifiers
{
    public class FacebookNotifier : Observer
    {
        public FacebookNotifier(Subject subject)
        {
            this.Subject = subject;
            this.Subject.AttachObserver(this);
        }

        public override void Notify(object arg)
        {
            if (Subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via FACEBOOK with new data" +
                                  "\n\tName: {0}" +
                                  "\n\tDescription: {1}" +
                                  "\n\tFile name: {2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName());
            }
        }
    }
}
