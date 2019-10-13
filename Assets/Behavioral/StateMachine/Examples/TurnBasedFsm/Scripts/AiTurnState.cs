using Patterns.StateMachine;
using UnityEngine;

namespace ExampleStateMachine
{
    public class AiTurnState : IState
    {
        public virtual bool IsPlayer => false;
        public bool IsInitialized { get; }

        public void OnInitialize() => Debug.Log("On Initialize ----> " + GetType());

        public void OnEnterState() => Debug.Log("On Enter ----> " + GetType() + " Is Player: " + IsPlayer);

        public void OnExitState() => Debug.Log("On Exit ----> " + GetType());

        public void OnUpdate() => Debug.Log("On Update ----> " + GetType());

        public void OnClear() => Debug.Log("On Clear ----> " + GetType());
    }
}