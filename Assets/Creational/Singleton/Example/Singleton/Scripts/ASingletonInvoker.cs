using UnityEngine;

namespace Singleton
{
    public class ASingletonInvoker : MonoBehaviour
    {
        [Button]
        void PrintRandomValue()
        {
            ASingleton.Instance.PrintRandomValue();
        }
    }
}