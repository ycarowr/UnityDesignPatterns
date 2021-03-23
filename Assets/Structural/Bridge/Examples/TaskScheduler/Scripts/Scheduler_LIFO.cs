using System;
using System.Collections;
using System.Collections.Generic;


namespace Bridge
{
    /// <summary>
    ///     An implementation last in first out
    /// </summary>
    public class Scheduler_FIFO : Queue<Action>, IScheduler
    {
        private bool IsOperating => this.Count > 0;

        public void Schedule(Action task)
        {
            this.Enqueue(task);
        }

        public void Execute()
        {
            if (!IsOperating)
                return;

            var first = this.Dequeue();
            first?.Invoke();
        }
    }
}