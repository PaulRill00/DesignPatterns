namespace Observer
{
    internal class Program
    {
        private static void Main()
        {
            Observer observer = new ConcreteObserver();
            Subject subject = new ConcreteSubject();

            subject.Attach(observer);

            subject.Notify();
        }
    }
}
