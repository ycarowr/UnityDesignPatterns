using System;


namespace Bridge
{
    /// <summary>
    ///     An implementation inferface
    /// </summary>
    public interface IScheduler
    {
        void Schedule(Action task);
        void Execute();
    }
}