using System;

namespace Patterns
{
    /// <summary>
    ///     Interface for a command queue.
    /// </summary>
    public interface ICommandQueue<T> where T : Command
    {
        /// <summary>
        ///     Whether the queue has zero elements or more.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        ///     Current size of the queue.
        /// </summary>
        int Size { get; }

        /// <summary>
        ///     Dispatched when the queue is empty.
        /// </summary>
        event Action OnEmpty;

        /// <summary>
        ///     Removes the first element to arrive in the queue.
        /// </summary>
        /// <returns></returns>
        T Dequeue();

        /// <summary>
        ///     Puts another element in the queue to be processed.
        /// </summary>
        /// <param name="command"></param>
        void Enqueue(T command);
    }
}