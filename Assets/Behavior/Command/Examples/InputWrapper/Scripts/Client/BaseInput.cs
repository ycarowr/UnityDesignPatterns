using UnityEngine;

namespace Command.InputWrapper
{
    using Patterns;
    
    /// <summary>
    ///     Binds the motion entity component to the same game object as the key binder.
    /// </summary>
    [RequireComponent(typeof(MotionEntity))]
    public abstract class BaseInput : KeyCommandBinder
    {
        protected IMotion MotionEntity => gameObject.GetComponent<MotionEntity>();
    }
}