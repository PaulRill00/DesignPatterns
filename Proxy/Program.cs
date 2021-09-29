using System;

namespace Proxy
{
    class Program
    {
        private static void Main()
        {
            var proxy = new Proxy<RealSubject>(callLimit: 3);

            try
            {
                proxy.Operation();
                proxy.Operation();
                proxy.Operation();
            }
            catch (CallOverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
