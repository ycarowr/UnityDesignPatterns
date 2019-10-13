using UnityEngine;

namespace AbstractFactory
{
    public partial class UiSystemPlatformsFactoryUsage
    {
        public interface IUiFactorySystem
        {
            IInput CreateInput(RuntimePlatform platform);
            IButton CreateButton(RuntimePlatform platform);
            IWindow CreateWindow(RuntimePlatform platform);

            IInput CreateInputXbox();
            IButton CreateButtonXbox();
            IWindow CreateWindowXbox();

            IInput CreateInputPs4();
            IButton CreateButtonPs4();
            IWindow CreateWindowPs4();
        }

        public class UiFactorySystem : IUiFactorySystem
        {
            readonly ButtonSystemFactory buttonFactory = new ButtonSystemFactory();
            readonly InputSystemFactory inputFactory = new InputSystemFactory();
            readonly WindowSystemFactory windowFactory = new WindowSystemFactory();

            public IInput CreateInput(RuntimePlatform platform) => inputFactory.CreateSystem(platform);

            public IButton CreateButton(RuntimePlatform platform) => buttonFactory.CreateSystem(platform);

            public IWindow CreateWindow(RuntimePlatform platform) => windowFactory.CreateSystem(platform);

            //--------------------------------------------------------------------------------------------------------------

            public IInput CreateInputXbox() => inputFactory.CreateXbox();

            public IButton CreateButtonXbox() => buttonFactory.CreateXbox();

            public IWindow CreateWindowXbox() => windowFactory.CreateXbox();

            //--------------------------------------------------------------------------------------------------------------

            public IInput CreateInputPs4() => inputFactory.CreatePs4();

            public IButton CreateButtonPs4() => buttonFactory.CreateXbox();

            public IWindow CreateWindowPs4() => windowFactory.CreatePs4();
        }
    }
}