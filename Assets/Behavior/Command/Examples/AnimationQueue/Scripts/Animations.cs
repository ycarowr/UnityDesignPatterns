using Patterns;
using UnityEngine;

namespace AnimationQueue
{
    /// <summary>
    ///     A motion animation of the game.
    /// </summary>
    public abstract class BaseMotionAnimation : Command
    {
        protected BaseMotionAnimation(IMotion entity)
        {
            MotionEntity = entity;
        }

        public IMotion MotionEntity { get; }

        /// <summary>
        ///     Executes the animation.
        /// </summary>
        public override void Execute()
        {
        }
    }

    public class MoveObject : BaseMotionAnimation
    {
        public MoveObject(IMotion entity, Vector3 amount) : base(entity)
        {
            Start = MotionEntity.transform.position;
            Amount = amount;
        }

        public Vector3 Start { get; }
        public Vector3 Amount { get; }

        public override void Execute()
        {
            MotionEntity.Move(Start + Amount);
        }
    }

    public class RotateObject : BaseMotionAnimation
    {
        public RotateObject(IMotion entity, Vector3 amount) : base(entity)
        {
            Start = MotionEntity.transform.rotation.eulerAngles;
            Amount = amount;
        }

        public Vector3 Start { get; }
        public Vector3 Amount { get; }

        public override void Execute()
        {
            MotionEntity.Rotate(Start + Amount);
        }
    }

    public class ScaleObject : BaseMotionAnimation
    {
        public ScaleObject(IMotion entity, Vector3 amount) : base(entity)
        {
            Start = MotionEntity.transform.localScale;
            Amount = amount;
        }

        public Vector3 Start { get; }
        public Vector3 Amount { get; }

        public override void Execute()
        {
            MotionEntity.Scale(Amount);
        }
    }
}