using System.Collections;
using System.Collections.Generic;
using Patterns;
using UnityEngine;

namespace Singleton
{
    public class ASingletonMB : SingletonMB<ASingletonMB>
    {
        protected override void OnAwake()
        {
            Debug.Log(GetType() + " has been created");
        }

        public void PrintRandomValue()
        {
            Debug.Log("Random: " + UnityEngine.Random.Range(0, 1f));
        }
    }
}