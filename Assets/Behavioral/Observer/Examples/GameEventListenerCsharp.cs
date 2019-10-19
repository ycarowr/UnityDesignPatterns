using UnityEngine;

namespace Patterns.GameEvents
{
    public class GameEventListenerCsharp : MonoBehaviour
    {
        void Start()
        {
            ObserverCsharpAction.OnStartGame += OnStartGame;
            ObserverCsharpAction.OnEndGame += OnEndGame;
            ObserverCsharpAction.OnPassTurn += OnPassTurn;
            ObserverCsharpAction.OnStartTurn += OnStartTurn;
            ObserverCsharpAction.OnEndTurn += OnEndTurn;

            //---------------- Or ----------------

            ObserverCsharpDelegates.OnStartGame += OnStartGame;
            ObserverCsharpDelegates.OnEndGame += OnEndGame;
            ObserverCsharpDelegates.OnPassTurn += OnPassTurn;
            ObserverCsharpDelegates.OnStartTurn += OnStartTurn;
            ObserverCsharpDelegates.OnEndTurn += OnEndTurn;
        }

        void OnDestroy()
        {
            ObserverCsharpAction.OnStartGame -= OnStartGame;
            ObserverCsharpAction.OnEndGame -= OnEndGame;
            ObserverCsharpAction.OnPassTurn -= OnPassTurn;
            ObserverCsharpAction.OnStartTurn -= OnStartTurn;
            ObserverCsharpAction.OnEndTurn -= OnEndTurn;

            //---------------- Or ----------------

            ObserverCsharpDelegates.OnStartGame -= OnStartGame;
            ObserverCsharpDelegates.OnEndGame -= OnEndGame;
            ObserverCsharpDelegates.OnPassTurn -= OnPassTurn;
            ObserverCsharpDelegates.OnStartTurn -= OnStartTurn;
            ObserverCsharpDelegates.OnEndTurn -= OnEndTurn;
        }

        //--------------------------------------------------------------------------------------------------------------

        void OnStartGame()
        {
        }

        void OnEndGame(int a, float b, bool c)
        {
        }

        void OnPassTurn()
        {
        }

        void OnStartTurn()
        {
        }

        void OnEndTurn()
        {
        }
    }
}