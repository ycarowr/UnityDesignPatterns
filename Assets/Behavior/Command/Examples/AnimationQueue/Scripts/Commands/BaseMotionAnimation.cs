using Patterns;

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
}