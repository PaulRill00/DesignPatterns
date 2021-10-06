
namespace Iterator
{
    interface Iterator<T>
    {
        public T GetNext();
        public bool HasNext();
    }
}
