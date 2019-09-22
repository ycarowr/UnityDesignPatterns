using UnityEngine;

namespace Command.AnimationQueue
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
        public void Move(Vector3 amount)
        {
            transform.position += amount;
        }

        /// <summary>
        ///     Scales the entity a certain amount.
        /// </summary>
        /// <param name="amount"></param>
        public void Scale(Vector3 amount)
        {
            transform.localScale += amount;
        }

        /// <summary>
        ///     Rotates the entity a certain amount.
        /// </summary>
        /// <param name="amount"></param>
        public void Rotate(Vector3 amount)
        {
            var current = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(current + amount);
        }
    }
}