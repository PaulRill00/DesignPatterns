using System.Collections.Generic;

namespace Observer
{
    internal abstract class Subject
    {
        private List<Observer> Observers { get; }

        protected Subject()
        {
            this.Observers = new List<Observer>();
        }

        public void Attach(Observer observer)
        {
            if (!this.Observers.Contains(observer))
            {
                this.Observers.Add(observer);
            }
        }

        public void Detach(Observer observer)
        {
            if (this.Observers.Contains(observer))
            {
                this.Observers.Remove(observer);
            }
        }

        public void Notify()
        {
            this.Observers.ForEach(observer => observer.Update());
        }
    }
}
