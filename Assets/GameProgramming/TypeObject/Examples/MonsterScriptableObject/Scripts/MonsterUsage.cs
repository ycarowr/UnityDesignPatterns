using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TypeObject.SO
{
    public class MonsterUsage : MonoBehaviour
    {
        [SerializeField] private Monster[] monsters;

        private void Start()
        {
            Attack();
            CheckHealth();
        }

        [Button]
        private void Attack()
        {
            foreach (var i in monsters)
            {
                Debug.Log($"Monster {i.name} attack: {i.GetAttack()}");
            }
        }
        
        [Button]
        private void CheckHealth()
        {
            foreach (var i in monsters)
            {
                Debug.Log($"Monster {i.name} health: {i.GetHealth()}");
            }
        }
    }
}