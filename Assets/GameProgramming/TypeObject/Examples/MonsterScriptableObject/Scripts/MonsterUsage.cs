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
        public void CreateBreeds()
        {
            // _water = new Breed(null, "Make a pond!", 40);
            // _fire = new Breed(null, "Incineration Blaze!", 30);
            //
            // //Lava overrides the only the health
            // _lava = new Breed(_fire, null, 45);
        }


        [Button]
        public void Attack()
        {
            foreach (var i in monsters)
            {
                Debug.Log($"Monster {i.name} attack: {i.GetAttack()}");
            }
        }
        
        [Button]
        public void CheckHealth()
        {
            foreach (var i in monsters)
            {
                Debug.Log($"Monster {i.name} health: {i.GetHealth()}");
            }
        }
    }
}