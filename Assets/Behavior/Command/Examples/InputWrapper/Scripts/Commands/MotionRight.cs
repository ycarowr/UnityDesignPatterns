using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Command responsible to move the entity right.
    /// </summary>
    public class MotionRight : BaseMotion
    {
        public MotionRight(IMotion entity) : base(entity, Vector3.right)
        {
        }
    }
}