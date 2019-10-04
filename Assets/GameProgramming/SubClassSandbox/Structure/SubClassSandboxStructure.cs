namespace SubClassSandboxStructure
{
    public class SubClassSandboxStructure
    {
        // The base class provides an common set of methods to the child classes.
        public class BaseClass
        {
            public void MethodA()
            {
                //Do something
            }

            protected virtual void ProtectedMethodB()
            {
                //Do something else
            }

            public virtual void VirtualMethodC()
            {
                //Do another thing
            }
        }


        //--------------------------------------------------------------------------------------------------------------

        //The derived classes have access to methods of the base class.
        //And they may override an appropriated method to implement certain feature.

        public class DerivedClassA : BaseClass
        {
            protected override void ProtectedMethodB()
            {
                //Override method B
            }
        }

        public class DerivedClassB : BaseClass
        {
            public override void VirtualMethodC()
            {
                //Override method C
            }
        }
    }
}