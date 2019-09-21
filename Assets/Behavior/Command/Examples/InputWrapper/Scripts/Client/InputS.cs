using UnityEngine;

namespace Command.InputWrapper
{
    using Patterns;
    
    /// <summary>
    ///     A component that checks the input and dispatches a command.
    /// </summary>
    public class InputS : BaseInput
    {
        protected override KeyCode Key => KeyCode.S;
        protected override BaseMotion GetCommand()
        {
            return new MotionDown(MotionEntity);
        }
    }
}