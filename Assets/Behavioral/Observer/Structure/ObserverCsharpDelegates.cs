using UnityEngine;

namespace Patterns
{
    public class ObserverCsharpDelegates : MonoBehaviour
    {
        #region Declaration

        public delegate void StartGameDelegate();

        public delegate void EndGameDelegate(int a, float b, bool c);

        public delegate void PassTurnDelegate();

        public delegate void StartTurnDelegate();

        public delegate void EndTurnDelegate();

        public static event StartGameDelegate OnStartGame = () => { };
        public static event EndGameDelegate OnEndGame = (a, b, c) => { };
        public static event PassTurnDelegate OnPassTurn = () => { };
        public static event StartTurnDelegate OnStartTurn = () => { };
        public static event EndTurnDelegate OnEndTurn = () => { };

        #endregion

        // -------------------------------------------------------------------------------------------------------------

        #region Invocators

        static void StartGame()
        {
            OnStartGame();
        }

        static void EndGame()
        {
            var a = 1;
            float b = 2;
            var c = true;
            OnEndGame(a, b, c);
        }

        static void PassTurn()
        {
            OnPassTurn();
        }

        static void StartTurn()
        {
            OnStartTurn();
        }

        static void EndTurn()
        {
            OnEndTurn();
        }

        #endregion
    }
}