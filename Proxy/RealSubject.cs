using System;

namespace Proxy
{
    class RealSubject : ISubject
    {
        public void Operation()
        {
            Console.WriteLine("RealSubject: Operation()");
        }
    }
}
