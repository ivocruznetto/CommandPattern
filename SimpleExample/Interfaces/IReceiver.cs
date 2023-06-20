using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleExample.Interfaces
{
    public interface IReceiver<in T, out O>
    where T : ICommand
    where O : IState
    {
        IState Handler(T command);
    }
}