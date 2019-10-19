public partial class TurnBasedGame
{
    public interface IGameMechanic
    {
        void StartTurn();
        void FinishTurn();
        void StartGame();
        void EndGame();
    }
}