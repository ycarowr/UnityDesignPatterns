using UnityEngine;

namespace FactoryMethod.World
{
    public partial class World : MonoBehaviour, IFactory
    {
        public Continent[] Continents;

        [Button]
        public void Create()
        {
            Continents = new Continent[]
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
}