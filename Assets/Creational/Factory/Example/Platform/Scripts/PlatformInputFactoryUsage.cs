using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformInputFactoryUsage : MonoBehaviour
{
    IInputSystem InputSystem { get; set; }

    [Button]
    void SetXBox()
    {
        InputSystem = InputSystemFactory.CreateXbox();
        Debug.Log("Input set to: " + InputSystem.GetType());
    }
    
    [Button]
    void SetPs4()
    {
        InputSystem = InputSystemFactory.CreatePs4();
        Debug.Log("Input set to: " + InputSystem.GetType());
    }
    
    [Button]
    void SetRandom()
    {
        var platforms = new RuntimePlatform[]
        {
            RuntimePlatform.XboxOne, RuntimePlatform.PS4
        };
        var index = Random.Range(0, platforms.Length);

        InputSystem = InputSystemFactory.CreateSystem(platforms[index]);
        Debug.Log("Input set to: " + InputSystem.GetType());
    }
        
    // --------------------------------------------------------------------------------------------------------------------
    
    //Define the input system interface
    public interface IInputSystem
    {
        KeyCode Jump { get; }
        KeyCode Attack { get; }
        KeyCode Block { get; }
        KeyCode PowerUp { get; }
    }

    //Define XBox input codes
    public class XboxInputSystem : IInputSystem
    {
        public KeyCode Jump => KeyCode.JoystickButton0;
        public KeyCode Attack => KeyCode.JoystickButton1;
        public KeyCode Block => KeyCode.JoystickButton2;
        public KeyCode PowerUp => KeyCode.JoystickButton3;
    }
    
    //Define Ps4 input codes
    public class Ps4InputSystem : IInputSystem
    {
        public KeyCode Jump => KeyCode.JoystickButton3;
        public KeyCode Attack => KeyCode.JoystickButton2;
        public KeyCode Block => KeyCode.JoystickButton1;
        public KeyCode PowerUp => KeyCode.JoystickButton0;
    }

    //Create the factory
    public class InputSystemFactory : ConsoleSystemFactory<Ps4InputSystem, XboxInputSystem, IInputSystem>
    {
        
    }
}
