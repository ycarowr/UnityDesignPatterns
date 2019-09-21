using UnityEngine;

namespace Command.InputWrapper
{
    using Patterns;
    
    /// <summary>
    ///     A component that checks the input and dispatches a command.
    /// </summary>
    public class InputA : BaseInput
    {
        protected override KeyCode Key => KeyCode.A;
        protected override BaseMotion GetCommand()
        {
            return new MotionLeft(MotionEntity);
        }
    }
}