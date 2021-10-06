using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class ConcreteCollection : IterableCollection<int>
    {
        public List<int> Collection;

        private Iterator<int> iterator;

        public ConcreteCollection()
        {
            Collection = new List<int>();
            this.iterator = new ForwardIterator(this);
        }

        public void SetIterator(Iterator<int> iterator)
        {
            this.iterator = iterator;
        }

        public IEnumerator<int> GetEnumerator()
        { 
            while (iterator.HasNext())
            {
                yield return iterator.GetNext();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
