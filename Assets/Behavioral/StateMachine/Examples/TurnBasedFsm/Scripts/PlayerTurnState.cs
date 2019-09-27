using Patterns.StateMachine;

namespace ExampleStateMachine
{
    public class PlayerTurnState : AiTurnState
    {
        public override bool IsPlayer => true;
    }
}