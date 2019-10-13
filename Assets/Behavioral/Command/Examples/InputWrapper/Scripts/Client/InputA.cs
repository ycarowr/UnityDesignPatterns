using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Class responsible to specify the bond key and the command.
    /// </summary>
    public class InputA : BaseInput
    {
        protected override KeyCode Key => KeyCode.A;

        protected override BaseMotion GetCommand() => new MotionLeft(MotionEntity);
    }
}