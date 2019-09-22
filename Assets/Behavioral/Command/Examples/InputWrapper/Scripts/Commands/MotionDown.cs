using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Command responsible to move the entity down.
    /// </summary>
    public class MotionDown : BaseMotion
    {
        public MotionDown(IMotion entity) : base(entity, Vector3.down)
        {
        }
    }
}