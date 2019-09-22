using UnityEngine;

namespace Command.UndoableMovement
{
    public interface IMotion
    {
        Transform transform { get; }
        void Move(Vector3 amount);
    }
}