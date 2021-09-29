using System;

namespace Observer
{
    internal class ConcreteObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Observer Received Update");
        }
    }
}
