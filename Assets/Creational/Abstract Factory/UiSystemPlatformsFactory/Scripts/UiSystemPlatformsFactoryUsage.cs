using UnityEngine;

namespace AbstractFactory
{
    public partial class UiSystemPlatformsFactoryUsage : MonoBehaviour
    {
        readonly UiFactorySystem uiFactory = new UiFactorySystem();
        IInput Input { get; set; }
        IButton Button { get; set; }
        IWindow Window { get; set; }


        [Button]
        void SetXBox()
        {
            Input = uiFactory.CreateInputXbox();
            Window = uiFactory.CreateWindowXbox();
            Button = uiFactory.CreateButtonXbox();
            PrintScheme();
        }

        [Button]
        void SetPs4()
        {
            Input = uiFactory.CreateInputPs4();
            Window = uiFactory.CreateWindowPs4();
            Button = uiFactory.CreateButtonPs4();
            PrintScheme();
        }

        [Button]
        void SetRandom()
        {
            var platforms = new[]
            {
                RuntimePlatform.XboxOne, RuntimePlatform.PS4
            };
            var index = Random.Range(0, platforms.Length);
            var platform = platforms[index];

            Input = uiFactory.CreateInput(platform);
            Window = uiFactory.CreateWindow(platform);
            Button = uiFactory.CreateButton(platform);
            PrintScheme();
        }

        void PrintScheme()
        {
            Debug.Log("Input type: " + Input.GetType());
            Debug.Log("Window type: " + Window.GetType());
            Debug.Log("Button type: " + Button.GetType());
        }
    }
}