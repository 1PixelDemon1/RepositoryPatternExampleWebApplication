
namespace RemoteStorageAPI.Services
{
    public class TemporaryStorage<T> : ITemporaryStorage<T>
    {
        private readonly ICollection<T> _data;

        public TemporaryStorage()
        {
            _data = new List<T>();
        }

        public void Add(T item)
        {
            _data.Add(item);
        }

        public int Count()
        {
            return _data.Count;
        }

        public T? FirstOrDefault(Func<T, bool> predicate)
        {
            return _data.FirstOrDefault(predicate);
        }

        public IEnumerable<T>? GetAll()
        {
            return _data;
        }

        public void Remove(T item)
        {
            _data.Remove(item);
        }
    }
}
