using System.Collections;
using UnityEngine;

namespace Patterns
{
    public class TimeredCommandQueue<T> : CommandQueue<T> where T : Command
    {
        [Tooltip("Time until dequeue the next command.")] [SerializeField] [Range(0.1f, 5)]
        float dequeueTime = 1f;

        /// <summary>
        ///     Whether the component is operating or not.
        /// </summary>
        public bool IsOperating { get; private set; }

        Coroutine Enqueueing { get; set; }
        Coroutine Dequeuing { get; set; }
        Coroutine Priority { get; set; }

        //--------------------------------------------------------------------------------------------------------------

        IEnumerator KeepDequeuing(float delay)
        {
            yield return new WaitForSeconds(delay);

            Dequeue();
            if (!IsEmpty)
                StartCoroutine(KeepDequeuing(dequeueTime));
            else
                IsOperating = false;
        }

        IEnumerator TimeredEnqueue(T command, float time)
        {
            if (time > 0)
                yield return new WaitForSeconds(time);
            Enqueue(command);
        }

        //--------------------------------------------------------------------------------------------------------------

        #region Operations

        /// <summary>
        ///     Enqueues a
        ///     <typeparam name="T"></typeparam>
        ///     command after a determined amount of time.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="timeToEnqueue"></param>
        public void EnqueueWithDelay(T command, float timeToEnqueue)
        {
            Enqueueing = StartCoroutine(TimeredEnqueue(command, timeToEnqueue));
        }

        /// <summary>
        ///     Enqueues a
        ///     <typeparam name="T"></typeparam>
        ///     command.
        /// </summary>
        /// <param name="command"></param>
        public override void Enqueue(T command)
        {
            base.Enqueue(command);

            if (IsOperating)
                return;

            UnQueueAll();
            IsOperating = true;
        }

        public void UnQueueAll()
        {
            if (!IsEmpty)
                StartCoroutine(KeepDequeuing(0));
        }

        /// <summary>
        ///     Reset the component completely.
        /// </summary>
        public void Reset()
        {
            if (Enqueueing != null)
                StopCoroutine(Enqueueing);
            if (Dequeuing != null)
                StopCoroutine(Dequeuing);
            if (Priority != null)
                StopCoroutine(Priority);

            Enqueueing = null;
            Dequeuing = null;
            Priority = null;

            Commands.Clear();
        }

        #endregion
    }
}