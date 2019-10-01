namespace SubclassSandbox.World
{
    public partial class World
    {
        #region Creatures

        class Merfolk : Creature
        {
            public override string Name => "Merfolk";
        }

        class Kraken : Creature
        {
            public override string Name => "Kraken";
        }

        class Leviathan : Creature
        {
            public override string Name => "Leviathan";
        }


        class Elf : Creature
        {
            public override string Name => "Elf";
        }

        class Beast : Creature
        {
            public override string Name => "Beast";
        }

        class Dwarf : Creature
        {
            public override string Name => "Dwarf";
        }

        class Human : Creature
        {
            public override string Name => "Human";
        }

        class Orc : Creature
        {
            public override string Name => "Orc";
        }

        class Goblin : Creature
        {
            public override string Name => "Goblin";
        }

        class Animal : Creature
        {
            public override string Name => "Animal";
        }

        #endregion
    }
}