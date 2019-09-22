namespace Command.UndoableMovement
{
    using Patterns;
    
    /// <summary>
    ///     A motion animation of the game.
    /// </summary>
    public abstract class BaseMotionAnimation : CommandUndo
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
}