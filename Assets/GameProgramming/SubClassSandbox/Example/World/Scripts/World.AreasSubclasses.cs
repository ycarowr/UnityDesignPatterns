namespace SubclassSandbox.World
{
    public partial class World
    {
        #region Subclasses

        class Island : Area
        {
            public override void Create()
            {
                Name = "Island";

                var water1 = new Water();
                var water2 = new Water();
                var water3 = new Water();
                var earth = new Earth();

                Elements = new Element[]
                {
                    water1, water2, water3, earth
                };

                foreach (var element in Elements)
                    element.Activate();
            }

            public override void Populate()
            {
                var kraken = new Kraken();
                var leviathan = new Leviathan();
                var merfolk1 = new Merfolk();
                var merfolk2 = new Merfolk();
                var merfolk3 = new Merfolk();

                Creatures = new Creature[]
                {
                    kraken, leviathan, merfolk1, merfolk2, merfolk3
                };

                foreach (var creature in Creatures)
                    creature.Speak();
            }
        }

        class Forest : Area
        {
            public override void Create()
            {
                Name = "Forest";

                var three1 = new Tree();
                var three2 = new Tree();
                var water = new Water();

                Elements = new Element[]
                {
                    three1, three2, water
                };

                foreach (var element in Elements)
                    element.Activate();
            }

            public override void Populate()
            {
                var elf = new Elf();
                var human = new Human();
                var animal1 = new Animal();
                var animal2 = new Animal();
                var beast = new Beast();

                Creatures = new Creature[]
                {
                    elf, human, animal1, animal2, beast
                };

                foreach (var creature in Creatures)
                    creature.Speak();
            }
        }

        class Mountain : Area
        {
            public override void Create()
            {
                Name = "Mountain";

                var fire = new Fire();
                var air = new Air();
                var earth1 = new Earth();
                var earth2 = new Earth();

                Elements = new Element[]
                {
                    air, earth1, earth2, fire
                };

                foreach (var element in Elements)
                    element.Activate();
            }

            public override void Populate()
            {
                var goblin = new Goblin();
                var human = new Human();
                var animal = new Animal();
                var orc = new Orc();
                var dwarf1 = new Dwarf();
                var dwarf2 = new Dwarf();

                Creatures = new Creature[]
                {
                    goblin, human, animal, orc, dwarf1, dwarf2
                };

                foreach (var creature in Creatures)
                    creature.Speak();
            }
        }

        class Swamp : Area
        {
            public override void Create()
            {
                Name = "Swamp";

                var three = new Tree();
                var water1 = new Water();
                var water2 = new Water();
                var earth1 = new Earth();
                var earth2 = new Earth();

                Elements = new Element[]
                {
                    three, water1, water2, earth1, earth2
                };

                foreach (var element in Elements)
                    element.Activate();
            }

            public override void Populate()
            {
                var goblin = new Goblin();
                var human = new Human();
                var animal = new Animal();
                var orc1 = new Orc();
                var merfolk = new Merfolk();

                Creatures = new Creature[]
                {
                    goblin, human, animal, orc1, merfolk
                };

                foreach (var creature in Creatures)
                    creature.Speak();
            }
        }

        class Plains : Area
        {
            public override void Create()
            {
                Name = "Plains";

                var earth1 = new Earth();
                var earth2 = new Earth();

                Elements = new Element[]
                {
                    earth1, earth2
                };

                foreach (var element in Elements)
                    element.Activate();
            }

            public override void Populate()
            {
                var human1 = new Human();
                var human2 = new Human();
                var animal = new Animal();
                var orc = new Orc();

                Creatures = new Creature[]
                {
                    human1, human2, animal, orc
                };

                foreach (var creature in Creatures)
                    creature.Speak();
            }
        }

        #endregion
    }
}