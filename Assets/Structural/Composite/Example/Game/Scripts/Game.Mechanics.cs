using UnityEngine;

public partial class TurnBasedGame
{
    public partial class Game
    {
        #region Mechanics

        /// <summary>
        ///     Class responsible to handle the enemies in a game.
        /// </summary>
        public class Enemies : IGameMechanic
        {
            public void StartTurn() => Debug.Log("Start Turn: " + GetType());

            public void FinishTurn() => Debug.Log("Finish Turn: " + GetType());

            public void StartGame() => Debug.Log("Start Game: " + GetType());

            public void EndGame() => Debug.Log("End Game: " + GetType());
        }

        /// <summary>
        ///     Class responsible to handle the player in the game.
        /// </summary>
        public class Player : IGameMechanic
        {
            public void StartTurn() => Debug.Log("Start Turn: " + GetType());

            public void FinishTurn() => Debug.Log("Finish Turn: " + GetType());

            public void StartGame() => Debug.Log("Start Game: " + GetType());

            public void EndGame() => Debug.Log("End Game: " + GetType());
        }

        /// <summary>
        ///  Class responsible to handle the end of turn
        /// </summary>
        public class TurnFinishes : IGameMechanic
        {
            public void StartTurn() => Debug.Log("Start Turn: " + GetType());

            public void FinishTurn() => Debug.Log("Finish Turn: " + GetType());

            public void StartGame() => Debug.Log("Start Game: " + GetType());

            public void EndGame() => Debug.Log("End Game: " + GetType());
        }

        /// <summary>
        ///     Class responsible to handle the start of turn
        /// </summary>
        public class TurnStarts : IGameMechanic
        {
            public void StartTurn() => Debug.Log("Start Turn: " + GetType());

            public void FinishTurn() => Debug.Log("Finish Turn: " + GetType());

            public void StartGame() => Debug.Log("Start Game: " + GetType());

            public void EndGame() => Debug.Log("End Game: " + GetType());
        }

        /// <summary>
        ///     Class responsible to handle the end game.
        /// </summary>
        public class GameEnd : IGameMechanic
        {
            public void StartTurn() => Debug.Log("Start Turn: " + GetType());

            public void FinishTurn() => Debug.Log("Finish Turn: " + GetType());

            public void StartGame() => Debug.Log("Start Game: " + GetType());

            public void EndGame() => Debug.Log("End Game: " + GetType());
        }

        /// <summary>
        ///     Class responsible to handle the start game.
        /// </summary>
        public class GameStart : IGameMechanic
        {
            public void StartTurn() => Debug.Log("Start Turn: " + GetType());

            public void FinishTurn() => Debug.Log("Finish Turn: " + GetType());

            public void StartGame() => Debug.Log("Start Game: " + GetType());

            public void EndGame() => Debug.Log("End Game: " + GetType());
        }

        #endregion
    }
}