using UnityEngine;

namespace Command.InputWrapper
{
    public class MotionUp : BaseMotion
    {
        public MotionUp(IMotion entity) : base(entity, Vector3.up)
        {
        }
    }
}