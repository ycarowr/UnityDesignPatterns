using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Command responsible to move the entity up.
    /// </summary>
    public class MotionUp : BaseMotion
    {
        public MotionUp(IMotion entity) : base(entity, Vector3.up)
        {
        }
    }
}