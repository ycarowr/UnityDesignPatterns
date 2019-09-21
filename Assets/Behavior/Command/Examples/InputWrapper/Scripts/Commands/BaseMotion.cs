using UnityEngine;

namespace Command.InputWrapper
{
    using Patterns;
    
    /// <summary>
    ///     A motion animation of the game.
    /// </summary>
    public abstract class BaseMotion : Command
    {
        protected BaseMotion(IMotion entity, Vector3 amount)
        {
            MotionEntity = entity;
            Amount = amount;
        }

        public IMotion MotionEntity { get; }
        public Vector3 Amount { get; }

        /// <summary>
        ///     Executes the animation.
        /// </summary>
        public override void Execute()
        {
            MotionEntity.Move(Amount);
        }
    }
}