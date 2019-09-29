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

        class Tree : Element
        {
            public override void Create()
            {
                Name = "Tree";
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