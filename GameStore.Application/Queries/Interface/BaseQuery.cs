using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Queries.Interface
{
    public abstract class BaseQuery<T> : IQuery<T>
    {
        public abstract void Validate();
        public abstract T Execute();
        public virtual T Handle()
        {
            Validate();
            return Execute();
        }
    }
}
