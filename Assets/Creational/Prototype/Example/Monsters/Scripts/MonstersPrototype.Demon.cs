public partial class MonstersPrototype
{
    public class Demon : Monster
    {
        public Demon(int health, int speed, int flySpeed) : base(health, speed)
        {
            FlySpeed = flySpeed;
        }

        public int FlySpeed { get; }

        public override Monster Clone()
        {
            return new Demon(Health, Speed, FlySpeed);
        }
    }
}