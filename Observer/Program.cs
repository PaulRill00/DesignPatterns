using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer observer = new ConcreteObserver();
            Subject subject = new ConcreteSubject();

            subject.Attach(observer);

            subject.Notify();
        }
    }
}
