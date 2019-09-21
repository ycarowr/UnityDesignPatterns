using UnityEngine;

namespace Command.InputWrapper
{
    using Patterns;
    
    /// <summary>
    ///     A component that checks the input and dispatches a command.
    /// </summary>
    public class InputD : BaseInput
    {
        protected override KeyCode Key => KeyCode.D;
        protected override BaseMotion GetCommand()
        {
            return new MotionRight(MotionEntity);
        }
    }
}