using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Command responsible to move the entity left.
    /// </summary>
    public class MotionLeft : BaseMotion
    {
        public MotionLeft(IMotion entity) : base(entity, Vector3.left)
        {
        }
    }
}