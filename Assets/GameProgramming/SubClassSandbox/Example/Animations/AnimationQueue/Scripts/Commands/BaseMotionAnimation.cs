namespace SubclassSandbox.Animation
{
    /// <summary>
    ///     A motion animation of the game.
    ///     This example shows how two patterns can work together.
    ///     Command and Subclass sandbox.
    /// </summary>
    public abstract class BaseMotionAnimation : Patterns.Command
    {
        protected BaseMotionAnimation(IMotion entity) => MotionEntity = entity;

        public IMotion MotionEntity { get; }

        /// <summary>
        ///     Executes the animation.
        /// </summary>
        public override void Execute()
        {
        }
    }
}