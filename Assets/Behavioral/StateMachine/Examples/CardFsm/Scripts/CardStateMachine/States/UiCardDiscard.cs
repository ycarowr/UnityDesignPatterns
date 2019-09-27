using Patterns.StateMachine;

namespace CardStateMachine
{
    /// <summary>
    ///     State when a cards has been discarded.
    /// </summary>
    public class UiCardDiscard : UiBaseCardState
    {
        public UiCardDiscard(PushDownAutomata fsm) : base(fsm)
        {
        }
    }
}