using UnityEngine;

public partial class TurnBasedGame : MonoBehaviour
{
    public Game game = new Game();

    [Button]
    public void StartTurn() => game.StartTurn();

    [Button]
    public void FinishTurn() => game.FinishTurn();

    [Button]
    public void StartGame() => game.StartGame();

    [Button]
    public void EndGame() => game.EndGame();
}