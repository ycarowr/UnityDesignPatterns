using UnityEngine;

namespace TypeObject.SO
{
    [CreateAssetMenu(menuName = "TypeObject/Breed")]
    public class Breed : ScriptableObject
    {
        [SerializeField] private Breed parent;
        [SerializeField] private int health;
        [SerializeField] private string attack;

        public string GetAttack()
        {
            var isAttackValid = string.IsNullOrEmpty(attack) && parent != null;
            return isAttackValid ? parent.attack : attack;
        }

        public int GetHealth()
        {
            var isHealthValid = health < 1 && parent != null;
            return isHealthValid ? parent.health : health;
        }
    }
}