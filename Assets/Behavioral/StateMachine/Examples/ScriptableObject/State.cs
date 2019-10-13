using UnityEngine;

namespace Tools.Patterns.StateMachineSO
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
        void Clear();
    }

    public class State : IState
    {
        void IState.Clear() => OnClearState();

        void IState.Enter() => OnEnterState();

        void IState.Exit() => OnExitState();

        void IState.Update() => OnUpdateState();

        protected virtual void OnInitializeState() => Debug.Log("On Initialize: " + GetType());
        protected virtual void OnEnterState() => Debug.Log("On Enter: " + GetType());
        protected virtual void OnExitState() => Debug.Log("On Exit: " + GetType());

        protected virtual void OnUpdateState()
        {
        }

        protected virtual void OnClearState()
        {
        }
    }
}