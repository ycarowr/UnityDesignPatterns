namespace AbstractFactory
{
    public partial class UiSystemPlatformsFactoryUsage
    {
        #region Concrete Factory

        //Create a factory for the Input System
        public class InputSystemFactory : Ps4XboxBaseFactory<Ps4Input, XboxInput, IInput>
        {
        }

        //Create a factory for the Window System
        public class WindowSystemFactory : Ps4XboxBaseFactory<Ps4Window, XboxWindow, IWindow>
        {
        }

        //Create a factory for the Button System
        public class ButtonSystemFactory : Ps4XboxBaseFactory<Ps4Button, XboxButton, IButton>
        {
        }

        #endregion
    }
}