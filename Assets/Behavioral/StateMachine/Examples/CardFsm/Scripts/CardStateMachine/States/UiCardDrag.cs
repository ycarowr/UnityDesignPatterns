using Patterns.StateMachine;

namespace CardStateMachine
{
    public class UiCardDrag : UiBaseCardState
    {
        public UiCardDrag(PushDownAutomata fsm) : base(fsm)
        {
        }
    }
}