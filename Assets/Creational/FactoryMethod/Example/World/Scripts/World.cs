using System;
using System.Collections.Generic;
using UnityEngine;

namespace Factory
{
    public class World : MonoBehaviour, ICreateable
    {
        public Continent[] Continents;
        [Button]
        public void Create()
        {
            Continents = new Continent []
            {
                new EastEarth(),
                new MiddleEarth(),
                new WestEarth()
            };

            foreach (var continent in Continents)
                continent.Create();
            
            PrintWorld();
        }

        public void PrintWorld()
        {
            foreach (var continent in Continents)
                Debug.Log(continent.ToString());
        }
    }

    //------------------------------------------------------------------------------------------------------------------

    #region Abstractions

    interface ICreateable
    {
        void Create();
    }

    public abstract class Continent : ICreateable
    {
        public Area[] Areas;
        public string Name = string.Empty;
        public abstract void Create();

        public override string ToString()
        {
            var s = String.Empty;
            s += Name + "\n";
            foreach (var area in Areas)
                s += area.ToString() + "\n";
            return s;
        }
    }

    public abstract class Area: ICreateable
    {
        public Creature[] Creatures;
        public Element[] Elements;
        public string Name = string.Empty;
        public abstract void Create();
        
        public override string ToString()
        {
            var s = String.Empty;
            s += Name + "\n";
            foreach (var c in Creatures)
                s += c.ToString() + "\n";
            foreach (var e in Elements)
                s += e.ToString() + "\n";
            return s;
        }
    }

    public abstract class Element: ICreateable
    {
        public string Name = string.Empty;
        public abstract void Create();
        public override string ToString()
        {
            return Name;
        }
    }

    public abstract class Creature : ICreateable
    {
        public string Name = string.Empty;
        public abstract void Create();
        public override string ToString()
        {
            return Name;
        }
    }

    #endregion

    //------------------------------------------------------------------------------------------------------------------

    #region Continents

    class MiddleEarth : Continent
    {
        public override void Create()
        {
            Name = "MiddleEarth";
            var island = new Island();
            var forest = new Forest();
            var swamp = new Swamp();
            var mountain = new Mountain();
            var plains = new Plains();

            Areas = new Area[]
            {
                island, forest, swamp, mountain, plains
            };

            foreach (var area in Areas)
                area.Create();
        }
    }
    
    class EastEarth : Continent
    {
        public override void Create()
        {
            Name = "EastEarth";
            var island = new Island();
            var forest = new Forest();
            var plains1 = new Plains();
            var plains2 = new Plains();

            Areas = new Area[]
            {
                island, forest, plains1, plains2
            };

            foreach (var area in Areas)
                area.Create();
        }
    }
    
    class WestEarth : Continent
    {
        public override void Create()
        {
            Name = "WestEarth";
            var island = new Island();
            var forest = new Forest();
            var swamp = new Swamp();
            var mountain1 = new Mountain();
            var mountain2 = new Mountain();

            Areas = new Area[]
            {
                island, forest, swamp, mountain1, mountain2
            };

            foreach (var area in Areas)
                area.Create();
        }
    }

    #endregion

    //------------------------------------------------------------------------------------------------------------------
    
    #region Areas
    class Island : Area
    {
        public override void Create()
        {
            Name = "Island";
            
            var water1 = new Water();
            var water2 = new Water();
            var water3 = new Water();

            Elements = new Element[]
            {
                water1, water2, water3
            };
            
            foreach (var element in Elements)
                element.Create();
            
            var kraken = new Kraken();
            var leviathan = new Leviathan();
            var merfolk1 = new Merfolk();
            var merfolk2 = new Merfolk();
            var merfolk3= new Merfolk();
            
            Creatures = new Creature[]
            {
                kraken, leviathan, merfolk1, merfolk2, merfolk3
            };

            foreach (var creature in Creatures)
                creature.Create();
        }
    }

    class Forest : Area
    {
        public override void Create()
        {
            Name = "Forest";
            
            var three1 = new Three();
            var three2 = new Three();
            var water = new Water();

            Elements = new Element[]
            {
                three1, three2, water
            };
            
            foreach (var element in Elements)
                element.Create();
            
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
                creature.Create();
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
                element.Create();
            
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
                creature.Create();
        }
    }

    class Swamp : Area
    {
        public override void Create()
        {
            Name = "Swamp";
            
            var three = new Three();
            var water1 = new Water();
            var water2 = new Water();
            var earth1 = new Earth();
            var earth2 = new Earth();

            Elements = new Element[]
            {
                three, water1, water2, earth1, earth2 
            };
            
            foreach (var element in Elements)
                element.Create();
            
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
                creature.Create();
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
                element.Create();
            
            var human1 = new Human();
            var human2 = new Human();
            var animal = new Animal();
            var orc = new Orc();
            
            Creatures = new Creature[]
            {
                human1, human2, animal, orc
            };

            foreach (var creature in Creatures)
                creature.Create();
        }
        
        
    }
    
    #endregion
    
    //------------------------------------------------------------------------------------------------------------------
    
    #region Elements

    class Water : Element
    {
        public override void Create()
        {
            Name = "Water";
        }
        
    }
    
    class Fire : Element
    {
        public override void Create()
        {
            Name = "Fire";
        }
    }
    
    class Air : Element
    {
        public override void Create()
        {
            Name = "Air";
        }
    }
    
    class Three : Element
    {
        public override void Create()
        {
            Name = "Three";
        }
    }
    
    class Earth : Element
    {
        public override void Create()
        {
            Name = "Earth";
        }
    }
    
    #endregion
    
    //------------------------------------------------------------------------------------------------------------------
    
    #region Creatures

    class Merfolk : Creature
    {
        public override void Create()
        {
            Name = "Merfolk";
        }
    }

    class Kraken : Creature
    {
        public override void Create()
        {
            Name = "Kraken";
        }
    }
    
    class Leviathan : Creature
    {
        public override void Create()
        {
            Name = "Leviathan";
        }
    }
    
    class Elf : Creature
    {
        public override void Create()
        {
            Name = "Elf";
        }
    }
    
    class Beast : Creature
    {
        public override void Create()
        {
            Name = "Beast";
        }
    }
    
    class Dwarf : Creature
    {
        public override void Create()
        {
            Name = "Dwarf";
        }
    }
    
    class Human : Creature
    {
        public override void Create()
        {
            Name = "Human";
        }
    }
    
    class Orc : Creature
    {
        public override void Create()
        {
            Name = "Orc";
        }
    }
    
    class Goblin : Creature
    {
        public override void Create()
        {
            Name = "Goblin";
        }
    }
    
    class Animal : Creature
    {
        public override void Create()
        {
            Name = "Animal";
        }
    }
    
    #endregion
}