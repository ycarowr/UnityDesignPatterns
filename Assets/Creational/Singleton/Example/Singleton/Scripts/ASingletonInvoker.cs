using System.Collections;
using System.Collections.Generic;
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