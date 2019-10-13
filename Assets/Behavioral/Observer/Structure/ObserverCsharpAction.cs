using System;
using UnityEngine;

namespace Patterns
{
    public class ObserverCsharpAction : MonoBehaviour
    {
        public static event Action OnStartGame = () => { };
        public static event Action<int, float, bool> OnEndGame = (a, b, c) => { };
        public static event Action OnPassTurn = () => { };
        public static event Action OnStartTurn = () => { };
        public static event Action OnEndTurn = () => { };

        // -------------------------------------------------------------------------------------------------------------

        #region Invocators

        static void OnOnStartGame() => OnStartGame();

        static void OnOnEndGame()
        {
            var a = 1;
            float b = 2;
            var c = true;
            OnEndGame(a, b, c);
        }

        static void OnOnPassTurn() => OnPassTurn();

        static void OnOnStartTurn() => OnStartTurn();

        static void OnOnEndTurn() => OnEndTurn();

        #endregion
    }
}