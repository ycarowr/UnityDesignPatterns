public partial class MonstersPrototype
{
    public class Ghost : Monster
    {
        public Ghost(int health, int speed) : base(health, speed)
        {
        }

        public int Health { get; }
        public int Speed { get; }

        public override Monster Clone() => new Ghost(Health, Speed);
    }
}