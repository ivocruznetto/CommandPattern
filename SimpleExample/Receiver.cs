using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleExample.Interfaces;

namespace SimpleExample
{
    public class Receiver : IReceiver<Command, IState>
    {
        public IState Handler(Command command)
        {
            command.Execute();
            return new State(200, "Comando executado com sucesso.");
        }
    }
}