using UnityEditor;
using UnityEngine;

namespace Bridge
{
    /// <summary>
    ///     A concrete usage of the interface.
    /// </summary>
    public class TaskSchedulerUI_LIFO : BaseScheduler
    {
        protected override IScheduler CreateScheduler()
        {
            return new Scheduler_LIFO();
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