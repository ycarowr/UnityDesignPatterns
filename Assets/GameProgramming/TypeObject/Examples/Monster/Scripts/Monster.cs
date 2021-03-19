namespace TypeObject
{
    public class Monster
    {
        private readonly Breed _breed;

        public Monster(Breed breed)
        {
            _breed = breed;
        }
        
        public string GetAttack()
        {
            return _breed.Attack; 
        }

        public int GetHealth()
        {
            return _breed.Health;  
        }
    }
}