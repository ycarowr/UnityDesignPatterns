using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     A motion animation of the game.
    /// </summary>
    public abstract class BaseMotion : Patterns.Command
    {
        protected BaseMotion(IMotion entity, Vector3 amount)
        {
            MotionEntity = entity;
            Amount = amount;
        }

        public IMotion MotionEntity { get; }
        public Vector3 Amount { get; }

        /// <summary>
        ///     Executes the movement.
        /// </summary>
        public override void Execute() => MotionEntity.Move(Amount);
    }
}