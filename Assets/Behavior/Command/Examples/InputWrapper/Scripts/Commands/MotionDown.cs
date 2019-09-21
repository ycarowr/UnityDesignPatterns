using UnityEngine;

namespace Command.InputWrapper
{
    public class MotionDown : BaseMotion
    {
        public MotionDown(IMotion entity) : base(entity, Vector3.down)
        {
        }
    }
}