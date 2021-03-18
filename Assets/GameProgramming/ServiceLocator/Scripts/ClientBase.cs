using UnityEngine;

namespace ServiceLocatorExample
{
    public abstract class ClientBase : MonoBehaviour
    {
        protected ILogger Logger;

        protected virtual void Start()
        {
            Logger = GetService<ILogger>();
            Logger?.Log("Initialization", $"{GetType()} is initialized");
        }

        protected T GetService<T>() where T : class
        {
            return ServiceLocator.GetService<T>();
        }
    }
}