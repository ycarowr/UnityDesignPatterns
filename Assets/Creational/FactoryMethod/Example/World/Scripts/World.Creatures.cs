namespace FactoryMethod.World
{
    public partial class World
    {
        #region Creatures

        class Merfolk : Creature
        {
            public override void Create() => Name = "Merfolk";
        }

        class Kraken : Creature
        {
            public override void Create() => Name = "Kraken";
        }

        class Leviathan : Creature
        {
            public override void Create() => Name = "Leviathan";
        }

        class Elf : Creature
        {
            public override void Create() => Name = "Elf";
        }

        class Beast : Creature
        {
            public override void Create() => Name = "Beast";
        }

        class Dwarf : Creature
        {
            public override void Create() => Name = "Dwarf";
        }

        class Human : Creature
        {
            public override void Create() => Name = "Human";
        }

        class Orc : Creature
        {
            public override void Create() => Name = "Orc";
        }

        class Goblin : Creature
        {
            public override void Create() => Name = "Goblin";
        }

        class Animal : Creature
        {
            public override void Create() => Name = "Animal";
        }

        #endregion
    }
}