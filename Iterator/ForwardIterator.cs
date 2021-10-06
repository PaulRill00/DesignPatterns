namespace Iterator
{
    class ForwardIterator : Iterator<int>
    {
        private ConcreteCollection collection;
        private int index;

        public ForwardIterator(ConcreteCollection c)
        {
            collection = c;
        }

        public int GetNext()
        {
            if (!HasNext()) return default;
            
            return collection.Collection[index++];
        }

        public bool HasNext()
        {
            return index < collection.Collection.Count;
        }
    }
}
