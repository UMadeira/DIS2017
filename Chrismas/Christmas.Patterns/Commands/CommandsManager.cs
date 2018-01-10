using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas.Patterns.Commands
{
    public class CommandsManager
    {
        #region Singleton
        static CommandsManager() { }
        private CommandsManager() { }

        public static CommandsManager Instance { get; } = new CommandsManager();
        #endregion

        public event EventHandler Notify;

        private List<ICommand> Commands { get; } = new List<ICommand>();

        private int Position { get; set; } = -1;

        private bool HasUndo => Position > -1;

        private bool HasRedo => Position < Commands.Count - 1;

        public void Execute( ICommand aCommand )
        {
            Debug.Assert( aCommand != null );

            if ( HasRedo )
            {
                Commands.RemoveRange( Position + 1, Commands.Count - Position + 1 );
            }

            aCommand.Execute();
            Commands.Add( aCommand );
            Position++;

            Notify?.Invoke( this, EventArgs.Empty ); 
        }

        public void Undo()
        {
            if ( ! HasUndo ) return;

            var command = Commands[Position];
            command.Undo();
            Position--;

            Notify?.Invoke(this, EventArgs.Empty);
        }

        public void Redo()
        {
            if ( ! HasRedo ) return;
            Commands[ ++Position ].Redo();

            Notify?.Invoke(this, EventArgs.Empty);
        }

    }
}
