namespace Patterns
{
    public abstract class Command
    {
        public abstract void Execute();
    }

    public abstract class CommandUndo : Command
    {
        public abstract void Undo();
    }
}