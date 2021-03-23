using System;
using UnityEngine;

namespace Bridge
{
    /// <summary>
    ///     An interface's Interface
    /// </summary>
    public abstract class BaseScheduler : MonoBehaviour
    {
        protected IScheduler Scheduler = null;

        protected virtual void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            Scheduler = CreateScheduler();
        }

        protected abstract IScheduler CreateScheduler();

        public void Schedule(Action task)
        {
            Scheduler?.Schedule(task);
        }

        public void Execute()
        {
            Scheduler?.Execute();
        }

        private float _count;
        private void Update()
        {
            _count += Time.deltaTime;
            if (_count > 1)
            {
                _count = 0;
                Execute();
            }
        }
    }
}