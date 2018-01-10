using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Christmas.Entities;
using Christmas.Patterns.Commands;

namespace Christmas.Shopping.Commands
{
    class CommandModifyName : ICommand
    {
        public CommandModifyName(  Receiver aReceiver, string aName )
        {
            Receiver = aReceiver;
            Name = aName;
        }

        public string Name { get; set; }

        public Receiver Receiver { get; }

        public void Execute()
        {
            var name = Receiver.Name;
            Receiver.Name = Name;
            Name = name;
        }

        public void Undo()
        {
            Execute();
        }

        public void Redo()
        {
            Execute();
        }
    }
}
