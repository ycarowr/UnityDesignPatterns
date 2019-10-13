using UnityEngine;

namespace Command.UndoableMovement
{
    /// <summary>
    ///     Concrete actor class, also called receiver, it is called by the command class.
    /// </summary>
    public class MotionEntity : MonoBehaviour, IMotion
    {
        /// <summary>
        ///     Moves the entity a certain amount.
        /// </summary>
        /// <param name="amount"></param>
        public void Move(Vector3 amount) => transform.position += amount;
    }
}