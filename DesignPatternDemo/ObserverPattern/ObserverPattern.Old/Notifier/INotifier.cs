using System;
namespace ObserverPattern.Old.Notifier
{
    public interface INotifier
    {
        void Notify(string name, string description, string fileName);
    }
}
