using GameStore.Infrastructure.InMemoryRepository.InMemoryStorage.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.InMemoryRepository.InMemoryStorage
{
    public class InMemoryStorage<T> : IInMemoryStorage<T>
    {
        public ICollection<T> Data { get; set; }

        public InMemoryStorage()
        {
            Data = new List<T>();
        }
    }
}
