using UnityEngine;

namespace Factory
{
    /// <summary>
    ///     Base for all the Artificial Intelligence of the game.
    /// </summary>
    public abstract class AiBase
    {
        public abstract string Move { get; }

        public void DoMove()
        {
            Debug.Log("My AI move is: " + Move);
        }
    }
}