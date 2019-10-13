using Patterns;
using UnityEngine;

namespace Pooler
{
    public class APooledObject : IPoolableObject
    {
        public void Restart() => Debug.Log(GetType() + " Pooled Back");
    }
}