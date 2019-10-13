using UnityEngine;

namespace Command.AnimationQueue
{
    /// <summary>
    ///     A command to scale a determined object.
    /// </summary>
    public class ScaleObject : BaseMotionAnimation
    {
        public ScaleObject(IMotion entity, Vector3 amount) : base(entity)
        {
            Start = MotionEntity.transform.localScale;
            Amount = amount;
        }

        public Vector3 Start { get; }
        public Vector3 Amount { get; }

        public override void Execute() => MotionEntity.Scale(Amount);
    }
}