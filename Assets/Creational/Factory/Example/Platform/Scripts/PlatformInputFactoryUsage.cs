using UnityEngine;

public partial class PlatformInputFactoryUsage : MonoBehaviour
{
    IInputSystem InputSystem { get; set; }

    [Button]
    void SetXBox()
    {
        InputSystem = InputSystemBaseFactory.CreateXbox();
        Debug.Log("Input set to: " + InputSystem.GetType());
    }

    [Button]
    void SetPs4()
    {
        InputSystem = InputSystemBaseFactory.CreatePs4();
        Debug.Log("Input set to: " + InputSystem.GetType());
    }

    [Button]
    void SetRandom()
    {
        var platforms = new[]
        {
            RuntimePlatform.XboxOne, RuntimePlatform.PS4
        };
        var index = Random.Range(0, platforms.Length);

        InputSystem = InputSystemBaseFactory.CreateSystem(platforms[index]);
        Debug.Log("Input set to: " + InputSystem.GetType());
    }
}