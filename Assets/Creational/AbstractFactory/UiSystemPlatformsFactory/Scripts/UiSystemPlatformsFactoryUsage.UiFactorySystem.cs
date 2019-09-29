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

            public IInput CreateInput(RuntimePlatform platform)
            {
                return inputFactory.CreateSystem(platform);
            }

            public IButton CreateButton(RuntimePlatform platform)
            {
                return buttonFactory.CreateSystem(platform);
            }

            public IWindow CreateWindow(RuntimePlatform platform)
            {
                return windowFactory.CreateSystem(platform);
            }

            //--------------------------------------------------------------------------------------------------------------

            public IInput CreateInputXbox()
            {
                return inputFactory.CreateXbox();
            }

            public IButton CreateButtonXbox()
            {
                return buttonFactory.CreateXbox();
            }

            public IWindow CreateWindowXbox()
            {
                return windowFactory.CreateXbox();
            }

            //--------------------------------------------------------------------------------------------------------------

            public IInput CreateInputPs4()
            {
                return inputFactory.CreatePs4();
            }

            public IButton CreateButtonPs4()
            {
                return buttonFactory.CreateXbox();
            }

            public IWindow CreateWindowPs4()
            {
                return windowFactory.CreatePs4();
            }
        }
    }
}