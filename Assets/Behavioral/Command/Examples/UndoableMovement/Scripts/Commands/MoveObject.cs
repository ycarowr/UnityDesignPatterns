using UnityEngine;

namespace Command.UndoableMovement
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

        public override void Execute() => MotionEntity.Move(Amount);

        public override void Undo() => MotionEntity.Move(-Amount);
    }
}