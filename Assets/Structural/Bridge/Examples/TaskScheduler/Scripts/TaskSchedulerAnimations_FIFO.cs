using System;
using UnityEngine;


namespace Bridge
{
    /// <summary>
    ///     A concrete usage of the interface.
    /// </summary>
    public class TaskSchedulerAnimations_FIFO : BaseScheduler
    {
        protected override IScheduler CreateScheduler()
        {
            return new Scheduler_FIFO();
        }

        private int testId;
        [Button]
        private void TestTask()
        {
            testId++;
            var text = $"Test task: {testId}";
            Schedule(() => Debug.Log(text));
        }
    }
}