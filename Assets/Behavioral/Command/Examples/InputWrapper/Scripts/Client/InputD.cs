using UnityEngine;

namespace Command.InputWrapper
{
    /// <summary>
    ///     Class responsible to specify the bond key and the command.
    /// </summary>
    public class InputD : BaseInput
    {
        protected override KeyCode Key => KeyCode.D;

        protected override BaseMotion GetCommand() => new MotionRight(MotionEntity);
    }
}