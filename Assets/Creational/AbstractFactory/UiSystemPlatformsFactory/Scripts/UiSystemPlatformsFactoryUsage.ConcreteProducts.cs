using UnityEngine;

namespace AbstractFactory
{
    public partial class UiSystemPlatformsFactoryUsage
    {
        //Concrete Product A1
        public class XboxInput : IInput
        {
            public KeyCode Jump => KeyCode.JoystickButton0;
            public KeyCode Attack => KeyCode.JoystickButton1;
            public KeyCode Block => KeyCode.JoystickButton2;
            public KeyCode PowerUp => KeyCode.JoystickButton3;
        }

        //Concrete Product A2
        public class Ps4Input : IInput
        {
            public KeyCode Jump => KeyCode.JoystickButton3;
            public KeyCode Attack => KeyCode.JoystickButton2;
            public KeyCode Block => KeyCode.JoystickButton1;
            public KeyCode PowerUp => KeyCode.JoystickButton0;
        }

        //------------------------------------------------------------------------------------------------------------------

        //Concrete Product B1
        public class XboxWindow : IWindow
        {
            public string Name => "XboxWindow";
        }

        //Concrete Product B2
        public class Ps4Window : IWindow
        {
            public string Name => "Ps4Window";
        }

        //------------------------------------------------------------------------------------------------------------------

        //Concrete Product C1
        public class XboxButton : IButton
        {
            public string Name => "XboxButton";
        }

        //Concrete Product C2
        public class Ps4Button : IButton
        {
            public string Name => "Ps4Button";
        }
    }
}