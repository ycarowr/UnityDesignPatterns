using System.Text;
using UnityEngine;

namespace SubclassSandbox.World
{
    public partial class World
    {
        #region Base classes

        public abstract class Continent
        {
            public Area[] Areas;
            public string Name = string.Empty;

            public abstract void Create();

            public void Populate()
            {
                foreach (var area in Areas)
                    area.Populate();
            }
        }

        public abstract class Area
        {
            public Creature[] Creatures;
            public Element[] Elements;
            public string Name = string.Empty;
            public abstract void Create();
            public abstract void Populate();

            public void Speak()
            {
                foreach (var creature in Creatures)
                    creature.Speak();
            }
        }

        public abstract class Creature
        {
            protected readonly StringBuilder sBuilder = new StringBuilder("My name is ");

            protected Creature() => sBuilder.Append(Name + "!");

            public abstract string Name { get; }

            public void Speak() => Debug.Log(sBuilder.ToString());
        }

        public abstract class Element
        {
            const string Activated = " Activated";
            public abstract string Name { get; }

            public void Activate() => Debug.Log(Name + Activated);
        }

        #endregion
    }
}