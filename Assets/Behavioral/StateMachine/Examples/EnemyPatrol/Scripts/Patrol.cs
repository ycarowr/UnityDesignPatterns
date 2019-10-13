using System.Collections;
using UnityEngine;

namespace EnemyPatrol
{
    public class Patrol
    {
        const float IdleTime = 3;

        public Patrol(Vector3 pointA, Vector3 pointB, MonoBehaviour handler)
        {
            PointA = pointA;
            PointB = pointB;
            Current = State.WalkA;
            Handler = handler;
        }

        MonoBehaviour Handler { get; }
        Vector3 PointA { get; }
        Vector3 PointB { get; }
        State Current { get; set; }
        Coroutine IdleRoutine { get; set; }

        public void Initialize() => Next();

        enum State
        {
            PointA,
            PointB,
            WalkA,
            WalkB
        }

        //------------------------------------------------------------------------------------------------------

        #region State Machine

        /// <summary>
        ///     Patrol point A.
        /// </summary>
        /// <returns></returns>
        IEnumerator StayA()
        {
            Debug.Log("Watch point A");
            yield return new WaitForSeconds(IdleTime);
            GoTo(State.WalkB);
        }

        /// <summary>
        ///     Patrol point B.
        /// </summary>
        /// <returns></returns>
        IEnumerator StayB()
        {
            Debug.Log("Watch point B");
            yield return new WaitForSeconds(IdleTime);
            GoTo(State.WalkA);
        }

        /// <summary>
        ///     Walk towards point A.
        /// </summary>
        void WalkTowardsA()
        {
            Debug.Log("Walk to A");
            //Move to point A immediately
            Handler.transform.position = PointA;
            GoTo(State.PointA);
        }

        /// <summary>
        ///     Walk towards point B.
        /// </summary>
        void WalkTowardsB()
        {
            Debug.Log("Walk to B");
            //Move to point B immediately
            Handler.transform.position = PointB;
            GoTo(State.PointB);
        }

        /// <summary>
        ///     Assigns the next state and dispatches its respective method.
        /// </summary>
        /// <param name="next"></param>
        void GoTo(State next)
        {
            Current = next;
            Next();
        }

        void Next()
        {
            switch (Current)
            {
                case State.PointA:
                    IdleRoutine = Handler.StartCoroutine(StayA());
                    break;
                case State.PointB:
                    IdleRoutine = Handler.StartCoroutine(StayB());
                    break;
                case State.WalkA:
                    WalkTowardsA();
                    break;
                case State.WalkB:
                    WalkTowardsB();
                    break;
            }
        }

        #endregion

        //------------------------------------------------------------------------------------------------------
    }
}