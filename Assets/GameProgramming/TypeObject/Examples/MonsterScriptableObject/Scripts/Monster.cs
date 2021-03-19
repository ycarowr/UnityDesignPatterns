using UnityEngine;

namespace TypeObject.SO
{
    public class Monster : MonoBehaviour
    {
        [SerializeField] private Breed breed;
        
        public string GetAttack()
        {
            return breed.GetAttack(); 
        }

        public int GetHealth()
        {
            return breed.GetHealth();  
        }
    }
}