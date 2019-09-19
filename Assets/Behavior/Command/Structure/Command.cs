namespace Patterns
{
    /// <summary>
    ///     The command base class.
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
    }

    /// <summary>
    ///     The undoable command base class.
    /// </summary>
    public abstract class CommandUndo : Command
    {
        public abstract void Undo();
    }
}