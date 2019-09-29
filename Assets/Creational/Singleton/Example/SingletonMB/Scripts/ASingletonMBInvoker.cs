using UnityEngine;

namespace Singleton
{
    public class ASingletonMBInvoker : MonoBehaviour
    {
        [Button]
        void PrintRandomValue()
        {
            ASingletonMB.Instance.PrintRandomValue();
        }
    }
}