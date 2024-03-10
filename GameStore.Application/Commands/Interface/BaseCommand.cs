using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Commands.Interface
{
    public abstract class BaseCommand : ICommand
    {
        public abstract void Validate();
        public abstract void Execute();
        public virtual void Handle()
        {
            Validate();
            Execute();
        }
    }
}
