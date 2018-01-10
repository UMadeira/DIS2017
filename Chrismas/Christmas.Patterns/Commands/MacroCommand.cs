using System.Collections.Generic;

namespace Christmas.Patterns.Commands
{
    public class MacroCommand : ICommand
    {
        private List<ICommand> Commands { get; } = new List<ICommand>();

        public void Add( ICommand aCommand )
        {
            Commands.Add( aCommand );
        }

        public void Remove( ICommand aCommand )
        {
            Commands.Remove( aCommand );
        }

        public void Execute()
        {
            foreach ( var command in Commands )
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            Commands.Reverse();
            foreach ( var command in Commands )
            {
                command.Undo();
            }
            Commands.Reverse();
        }

        public void Redo()
        {
            foreach (var command in Commands)
            {
                command.Redo();
            }
        }
    }
}
