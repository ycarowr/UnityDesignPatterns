using Patterns.StateMachine;

namespace CardStateMachine
{
    /// <summary>
    ///     UI Card Idle behavior.
    /// </summary>
    public class UiCardIdle : UiBaseCardState
    {
        //--------------------------------------------------------------------------------------------------------------

        public UiCardIdle(PushDownAutomata fsm) : base(fsm)
        {
        }
    }
}