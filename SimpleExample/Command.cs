using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleExample.Interfaces;

namespace SimpleExample
{
    public class Command : ICommand
    {
        public Command(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public void Execute()
        {
            Console.WriteLine($"Comando executado: {this.Id} - {this.Name}");
        }
    }
}