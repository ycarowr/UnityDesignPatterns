namespace FactoryMethod.World
{
    public interface IFactory
    {
        void Create();
    }

    public partial class World
    {
        #region Factories

        public abstract class Continent : IFactory
        {
            public Area[] Areas;
            public string Name = string.Empty;
            public abstract void Create();

            public override string ToString()
            {
                var s = string.Empty;
                s += Name + "\n";
                foreach (var area in Areas)
                    s += area + "\n";
                return s;
            }
        }

        public abstract class Area : IFactory
        {
            public Creature[] Creatures;
            public Element[] Elements;
            public string Name = string.Empty;
            public abstract void Create();

            public override string ToString()
            {
                var s = string.Empty;
                s += Name + "\n";
                foreach (var c in Creatures)
                    s += c + "\n";
                foreach (var e in Elements)
                    s += e + "\n";
                return s;
            }
        }

        public abstract class Element : IFactory
        {
            public string Name = string.Empty;
            public abstract void Create();

            public override string ToString()
            {
                return Name;
            }
        }

        public abstract class Creature : IFactory
        {
            public string Name = string.Empty;
            public abstract void Create();

            public override string ToString()
            {
                return Name;
            }
        }

        #endregion
    }
}