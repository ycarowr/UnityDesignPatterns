using UnityEngine;

namespace Command.InputWrapper
{
    public class MotionLeft : BaseMotion
    {
        public MotionLeft(IMotion entity) : base(entity, Vector3.left)
        {
        }
    }
}