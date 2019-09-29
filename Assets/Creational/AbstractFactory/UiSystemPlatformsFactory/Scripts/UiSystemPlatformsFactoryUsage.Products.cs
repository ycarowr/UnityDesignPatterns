using UnityEngine;

namespace AbstractFactory
{
    public partial class UiSystemPlatformsFactoryUsage
    {
        // Product A
        public interface IInput
        {
            KeyCode Jump { get; }
            KeyCode Attack { get; }
            KeyCode Block { get; }
            KeyCode PowerUp { get; }
        }

        // Product B
        public interface IWindow
        {
            string Name { get; }
        }

        // Product C
        public interface IButton
        {
            string Name { get; }
        }
    }
}