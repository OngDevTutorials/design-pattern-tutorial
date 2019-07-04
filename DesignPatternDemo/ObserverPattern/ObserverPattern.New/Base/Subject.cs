using System;
using System.Collections.Generic;

namespace ObserverPattern.New.Base
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(object arg)
        {
            _observers.ForEach((observer) => observer.Notify(arg));
        }
    }
}
