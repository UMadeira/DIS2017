using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Christmas.Entities;
using Christmas.Patterns.Commands;

namespace Christmas.Shopping.Commands
{
    class CommandCreatePerson : ICommand
    {
        public CommandCreatePerson( string aName = "Person" )
        {
            Name = aName;
        }

        public string Name { get; set; }

        public Person Person { get; private set; }

        public void Execute()
        {
            Person = new Person { Name = Name };
        }

        public void Undo()
        {
            Person = null;
        }

        public void Redo()
        {
            Execute();
        }
    }
}
