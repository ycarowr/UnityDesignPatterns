using UnityEngine;

namespace SubclassSandbox.World
{
    public partial class World : MonoBehaviour
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

            //Create the world
            foreach (var continent in Continents)
                continent.Create();

            //Populate the world
            foreach (var continent in Continents)
                continent.Populate();

            //Creatures Speak!
            foreach (var continent in Continents)
                foreach (var area in continent.Areas)
                    area.Speak();
        }
    }
}