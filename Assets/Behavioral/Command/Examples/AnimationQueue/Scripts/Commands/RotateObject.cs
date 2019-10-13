using UnityEngine;

namespace Command.AnimationQueue
{
    /// <summary>
    ///     A command to rotate a determined object.
    /// </summary>
    public class RotateObject : BaseMotionAnimation
    {
        public RotateObject(IMotion entity, Vector3 amount) : base(entity)
        {
            Start = MotionEntity.transform.rotation.eulerAngles;
            Amount = amount;
        }

        public Vector3 Start { get; }
        public Vector3 Amount { get; }

        public override void Execute() => MotionEntity.Rotate(Start + Amount);
    }
}