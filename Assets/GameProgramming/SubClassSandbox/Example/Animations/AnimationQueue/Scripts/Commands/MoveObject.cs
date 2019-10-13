using UnityEngine;

namespace SubclassSandbox.Animation
{
    /// <summary>
    ///     A command to move a determined object.
    /// </summary>
    public class MoveObject : BaseMotionAnimation
    {
        public MoveObject(IMotion entity, Vector3 amount) : base(entity)
        {
            Start = MotionEntity.transform.position;
            Amount = amount;
        }

        public Vector3 Start { get; }
        public Vector3 Amount { get; }

        public override void Execute() => MotionEntity.Move(Start + Amount);
    }
}