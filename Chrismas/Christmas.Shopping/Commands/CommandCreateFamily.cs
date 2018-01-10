using Christmas.Entities;
using Christmas.Patterns.Commands;

namespace Christmas.Shopping.Commands
{
    class CommandCreateFamily : ICommand
    {
        public CommandCreateFamily( string aName = "Family" )
        {
            Name = aName;
        }

        public string Name { get; set; }

        public Family Family { get; private set; }

        public void Execute()
        {
            Family = new Family { Name = Name };
        }

        public void Undo()
        {
            Family = null;
        }

        public void Redo()
        {
            Execute();
        }
    }
}
