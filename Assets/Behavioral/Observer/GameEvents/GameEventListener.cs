using UnityEngine;

namespace Patterns.GameEvents
{
    public class GameEventListener : MonoBehaviour, IListener,
        IStartGame, IEndGame, IPassTurn, IStartTurn, IEndTurn
    {
        [SerializeField] Observer GameEvents;

        void IEndGame.OnEndGame(int a, float b, bool c)
        {
        }

        void IEndTurn.OnEndTurn()
        {
        }

        void IPassTurn.OnPassTurn()
        {
        }

        //--------------------------------------------------------------------------------------------------------------

        void IStartGame.OnStartGame()
        {
        }

        void IStartTurn.OnStartTurn()
        {
        }

        void Start()
        {
            GameEvents.AddListener(this);
        }

        void OnDestroy()
        {
            GameEvents.RemoveListener(this);
        }
    }

    #region Game Events Definition

    public interface IStartGame : ISubject
    {
        void OnStartGame();
    }

    public interface IEndGame : ISubject
    {
        void OnEndGame(int a, float b, bool c);
    }

    public interface IPassTurn : ISubject
    {
        void OnPassTurn();
    }

    public interface IStartTurn : ISubject
    {
        void OnStartTurn();
    }

    public interface IEndTurn : ISubject
    {
        void OnEndTurn();
    }

    #endregion
}