using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Commands.Interface
{
    public interface ICommand
    {
        void Validate();
        void Execute();
        void Handle();
    }
}
