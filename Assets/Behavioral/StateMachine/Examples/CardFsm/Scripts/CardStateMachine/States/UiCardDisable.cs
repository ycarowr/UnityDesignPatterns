using Patterns.StateMachine;

namespace CardStateMachine
{
    /// <summary>
    ///     This state disables the collider of the card.
    /// </summary>
    public class UiCardDisable : UiBaseCardState
    {
        public UiCardDisable(BaseStateMachine fsm) : base(fsm)
        {
        }
    }
}