namespace RemoteStorageAPI.Services
{
    public interface ITemporaryStorage<T>
    {
        T? FirstOrDefault(Func<T, bool> predicate);
        int Count();
        void Remove(T item);
        void Add(T item);
        IEnumerable<T>? GetAll();
    }
}
