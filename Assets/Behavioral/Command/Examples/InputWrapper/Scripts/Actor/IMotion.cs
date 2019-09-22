using UnityEngine;

namespace Command.InputWrapper
{
    public interface IMotion
    {
        Transform transform { get; }
        void Move(Vector3 amount);
    }
}