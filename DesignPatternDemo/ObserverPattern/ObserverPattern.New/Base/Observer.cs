using System;
namespace ObserverPattern.New.Base
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Notify(object arg);
    }
}
