namespace Iterator
{
    class BackwardsIterator : Iterator<int>
    {
        private ConcreteCollection collection;
        private int index;

        public BackwardsIterator(ConcreteCollection c)
        {
            collection = c;
            index = collection.Collection.Count - 1;
        }

        public int GetNext()
        {
            return !HasNext() ? default : collection.Collection[index--];
        }

        public bool HasNext()
        {
            return index >= 0;
        }
    }
}
