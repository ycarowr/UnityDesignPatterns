using UnityEngine;

namespace Command.InputWrapper
{
    public class MotionRight : BaseMotion
    {
        public MotionRight(IMotion entity) : base(entity, Vector3.right)
        {
        }
    }
}