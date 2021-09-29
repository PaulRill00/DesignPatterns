using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Observer Received Update");
        }
    }
}
