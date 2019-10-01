namespace SubclassSandbox.World
{
    public partial class World
    {
        #region Elements

        class Water : Element
        {
            public override string Name => "Water";
        }

        class Fire : Element
        {
            public override string Name => "Fire";
        }

        class Air : Element
        {
            public override string Name => "Air";
        }

        class Tree : Element
        {
            public override string Name => "Tree";
        }

        class Earth : Element
        {
            public override string Name => "Earth";
        }

        #endregion
    }
}