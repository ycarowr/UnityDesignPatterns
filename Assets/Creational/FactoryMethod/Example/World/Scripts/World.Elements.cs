namespace FactoryMethod.World
{
    public partial class World
    {
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
    }
}