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

            protected void ProtectedMethodB()
            {
                //Do something else
            }

            public virtual void VirtualMethodC()
            {
                //Do another thing
            }
        }


        //--------------------------------------------------------------------------------------------------------------

        //The derived classes have access to the methods a common method in the parent class.
        //And they also can override an appropriated method to implement certain feature.

        public class DerivedClassA : BaseClass
        {
            public override void VirtualMethodC()
            {
                //Override method C
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