using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns
{
    /// <summary>
    ///     A command queue where the first enqueued command executes first (FIFO).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CommandQueue<T> : MonoBehaviour, ICommandQueue<T> where T : Command
    {
        /// <summary>
        ///     Register that contains all queued commands.
        /// </summary>
        protected Queue<T> Commands { get; } = new Queue<T>();

        /// <summary>
        ///     Dispatched when the queue is empty.
        /// </summary>
        public event Action OnEmpty = () => { };

        /// <summary>
        ///     Whether the queue is empty or not.
        /// </summary>
        public bool IsEmpty => Size == 0;

        /// <summary>
        ///     Size of the queue.
        /// </summary>
        public int Size => Commands.Count;

        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        ///     Enqueues a
        ///     <typeparam name="T"> command. </typeparam>
        ///     >
        /// </summary>
        /// <param name="command"></param>
        public virtual void Enqueue(T command)
        {
            if (command == null)
                return;

            Commands?.Enqueue(command);
        }

        /// <summary>
        ///     Dequeues a
        ///     <typeparam name="T"> command.</typeparam>
        /// </summary>
        /// <returns></returns>
        public virtual T Dequeue()
        {
            if (IsEmpty)
                return null;

            var command = Commands.Dequeue();
            command?.Execute();

            if (IsEmpty)
                OnEmptyQueue();
            return command;
        }

        /// <summary>
        ///     Emits on empty event.
        /// </summary>
        protected virtual void OnEmptyQueue() => OnEmpty?.Invoke();
    }
}