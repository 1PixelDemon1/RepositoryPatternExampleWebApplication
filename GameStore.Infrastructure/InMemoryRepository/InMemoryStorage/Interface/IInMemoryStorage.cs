using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.InMemoryRepository.InMemoryStorage.Interface
{
    public interface IInMemoryStorage<T>
    {
        public ICollection<T> Data { get; set; }
    }
}
