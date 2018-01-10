namespace Christmas.Patterns.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
