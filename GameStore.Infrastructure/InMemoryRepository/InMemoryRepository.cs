using GameStore.Application.Repository;
using GameStore.Infrastructure.InMemoryRepository.InMemoryStorage.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.InMemoryRepository
{
    public abstract class InMemoryRepository<T> : IRepository<T>
    {
        protected readonly IInMemoryStorage<T> _storage;

        public InMemoryRepository(IInMemoryStorage<T> storage)
        {
            _storage = storage;
        }

        public virtual IEnumerable<T>? GetAll()
        {
            return _storage.Data;
        }

        public virtual void Remove(T value)
        {
            _storage.Data.Remove(value);
        }

        public abstract void Add(T value);
        public abstract void Update(T value);

    }
}
