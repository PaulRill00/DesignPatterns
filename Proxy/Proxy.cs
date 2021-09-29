using System;

namespace Proxy
{
    internal class Proxy<T> : ISubject where T : ISubject, new()
    {
        private T Subject { get; }
        private int CallLimit { get; }
        private int Calls { get; set; } = 0;

        public Proxy(int callLimit = 0)
        {
            this.Subject = new T();
            this.CallLimit = callLimit;
        }

        public void Operation()
        {
            this.Calls++;

            if (this.Calls >= this.CallLimit)
            {
                throw new CallOverflowException();
            }


            this.Subject.Operation();
        }
    }

    public class CallOverflowException : Exception
    {
        public CallOverflowException() : base("This Proxy reached it's call limit") { }
    }
}
