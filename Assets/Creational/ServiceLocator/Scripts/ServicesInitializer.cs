using UnityEngine;

namespace ServiceLocatorExample
{
    public class ServicesInitializer : MonoBehaviour
    {
        private void Awake()
        {
            //First thing to do
            ServiceLocator.InitializeServices();
        }
    }
}