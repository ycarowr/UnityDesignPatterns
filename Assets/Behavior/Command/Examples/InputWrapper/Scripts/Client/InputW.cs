using UnityEngine;

namespace Command.InputWrapper
{
    using Patterns;
    
    /// <summary>
    ///     A component that checks the input and dispatches a command.
    /// </summary>
    public class InputW : BaseInput
    {
        protected override KeyCode Key => KeyCode.W;
        protected override BaseMotion GetCommand()
        {
            return new MotionUp(MotionEntity);
        }
    }
}
