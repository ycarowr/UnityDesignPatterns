using Patterns.StateMachine;
using UnityEngine;

namespace CardStateMachine
{
    /// <summary>
    ///     Base UI Card State.
    /// </summary>
    public abstract class UiBaseCardState : IState
    {
        protected UiBaseCardState(BaseStateMachine fsm)
        {
            Fsm = fsm;
            IsInitialized = true;
        }

        protected BaseStateMachine Fsm { get; }
        public bool IsInitialized { get; }

        //--------------------------------------------------------------------------------------------------------------

        #region FSM

        public virtual void OnInitialize()
        {
            Debug.Log(GetType() + " -----> Initialized");
        }

        public virtual void OnEnterState()
        {
            Debug.Log(GetType() + " -----> On Enter");
        }

        public virtual void OnExitState()
        {
            Debug.Log(GetType() + " -----> On Exit");
        }

        public virtual void OnUpdate()
        {
            Debug.Log(GetType() + " -----> On Update");
        }

        public virtual void OnClear()
        {
            Debug.Log(GetType() + " -----> On Clear");
        }

        #endregion

        //--------------------------------------------------------------------------------------------------------------
    }
}