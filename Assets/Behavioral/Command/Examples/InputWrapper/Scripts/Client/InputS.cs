using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Class responsible to specify the bond key and the command.
    /// </summary>
    public class InputS : BaseInput
    {
        protected override KeyCode Key => KeyCode.S;

        protected override BaseMotion GetCommand() => new MotionDown(MotionEntity);
    }
}