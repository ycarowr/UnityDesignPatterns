using System;
using System.Collections.Generic;


namespace Bridge
{
    /// <summary>
    ///     An implementation first in first out
    /// </summary>
    public class Scheduler_LIFO : Stack<Action>, IScheduler
    {
        private bool IsOperating => this.Count > 0;

        public void Schedule(Action task)
        {
            this.Push(task);
        }

        public void Execute()
        {
            if (!IsOperating)
                return;

            var first = this.Pop();          
            first?.Invoke();
        }
    }
}