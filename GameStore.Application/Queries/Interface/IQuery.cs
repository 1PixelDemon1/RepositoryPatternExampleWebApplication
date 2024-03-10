using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Queries.Interface
{
    public interface IQuery<T>
    {
        void Validate();
        T Execute();
        T Handle();
    }
}
