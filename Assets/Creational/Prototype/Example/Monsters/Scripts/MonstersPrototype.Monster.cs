public partial class MonstersPrototype
{
    //The Prototype Class
    public abstract class Monster
    {
        protected Monster(int health, int speed)
        {
            Health = health;
            Speed = speed;
        }

        public int Health { get; }
        public int Speed { get; }

        public abstract Monster Clone();
    }
}