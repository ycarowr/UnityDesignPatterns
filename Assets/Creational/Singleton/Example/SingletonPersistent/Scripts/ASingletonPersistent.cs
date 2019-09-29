using Patterns;
using UnityEngine;

namespace Singleton
{
    public class ASingletonPersistent : PersistentSingleton<ASingletonPersistent>
    {
        void Awake()
        {
            Debug.Log(GetType() + " has been created");
        }

        public void PrintRandomValue()
        {
            Debug.Log("Random: " + Random.Range(0, 1f));
        }
    }
}