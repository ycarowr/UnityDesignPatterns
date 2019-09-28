using UnityEngine;

public partial class PlatformInputFactoryUsage
{
    //Define the input system interface
    public interface IInputSystem
    {
        KeyCode Jump { get; }
        KeyCode Attack { get; }
        KeyCode Block { get; }
        KeyCode PowerUp { get; }
    }

    //Define XBox input scheme
    public class XboxInputSystem : IInputSystem
    {
        public KeyCode Jump => KeyCode.JoystickButton0;
        public KeyCode Attack => KeyCode.JoystickButton1;
        public KeyCode Block => KeyCode.JoystickButton2;
        public KeyCode PowerUp => KeyCode.JoystickButton3;
    }

    //Define Ps4 input scheme
    public class Ps4InputSystem : IInputSystem
    {
        public KeyCode Jump => KeyCode.JoystickButton3;
        public KeyCode Attack => KeyCode.JoystickButton2;
        public KeyCode Block => KeyCode.JoystickButton1;
        public KeyCode PowerUp => KeyCode.JoystickButton0;
    }

    //Create a factory for the input system
    public class InputSystemBaseFactory : Ps4XboxBaseFactory<Ps4InputSystem, XboxInputSystem, IInputSystem>
    {
    }
}