namespace TypeObject
{
    public class Breed
    {
        public readonly int Health;
        public readonly string Attack;
        
        public Breed(Breed parent, string attack, int health)
        {
            var isAttackValid = string.IsNullOrEmpty(attack) && parent != null; 
            Attack = isAttackValid ? parent.Attack : attack;

            var isHealthValid = health < 1 && parent != null;
            Health = isHealthValid ? parent.Health : health;
        }
    }
}