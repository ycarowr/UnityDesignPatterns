namespace FactoryMethod.World
{
    public partial class World
    {
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
    }
}