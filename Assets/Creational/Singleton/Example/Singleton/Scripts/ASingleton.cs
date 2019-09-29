using Patterns;
using UnityEngine;

namespace Singleton
{
    public class ASingleton : Singleton<ASingleton>
    {
        public ASingleton()
        {
            Debug.Log(GetType() + " has been created!");
        }

        public void PrintRandomValue()
        {
            Debug.Log("Random: " + Random.Range(0, 1f));
        }
    }
}