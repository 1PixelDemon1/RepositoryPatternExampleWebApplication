using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Repository
{
    public interface IRepository<T>
    {
        void Add(T value);
        void Update(T value);
        void Remove(T value);
        IEnumerable<T>? GetAll();
    }
}
