using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Class responsible to specify the bond key and the command.
    /// </summary>
    public class InputW : BaseInput
    {
        protected override KeyCode Key => KeyCode.W;

        protected override BaseMotion GetCommand() => new MotionUp(MotionEntity);
    }
}