using Patterns.StateMachine;

namespace CardStateMachine
{
    /// <summary>
    ///     This state draw the collider of the card.
    /// </summary>
    public class UiCardDraw : UiBaseCardState
    {
        public UiCardDraw(BaseStateMachine fsm) : base(fsm)
        {
        }
    }
}