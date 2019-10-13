using Patterns.StateMachine;

namespace ExampleStateMachine
{
    public class TurnBasedStateMachine : BaseStateMachine
    {
        readonly AiTurnState aiTurn = new AiTurnState();

        readonly EndGameState endGame = new EndGameState();

        //Create states
        readonly PlayerTurnState playerTurn = new PlayerTurnState();
        readonly StartGameState startGame = new StartGameState();

        /// <summary>
        ///     Register the states before the initialization.
        /// </summary>
        protected override void OnBeforeInitialize()
        {
            RegisterState(playerTurn);
            RegisterState(aiTurn);
            RegisterState(startGame);
            RegisterState(endGame);
        }

        public void PlayerTurn() => PushState(playerTurn);

        public void AiTurn() => PushState(aiTurn);

        public void StartGame() => PushState(startGame);

        public void EndGame() => PushState(endGame);
    }
}