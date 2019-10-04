
# Subclass Sandbox

## Definitions

"Define behavior in a subclass using a set of operations provided by its base class."

"A base class defines an abstract sandbox method and several provided operations. Marking them protected makes it clear that they are for use by derived classes. Each derived sandboxed subclass implements the sandbox method using the provided operations."


When to use: 
1. You have a base class with a number of derived classes.
2. The base class is able to provide all of the operations that a derived class may need to perform.
3. There is behavioral overlap in the subclasses and you want to make it easier to share code between them.
4. You want to minimize coupling between those derived classes and the rest of the program.

Notes: 

1. Be careful with [brittle base class](https://en.wikipedia.org/wiki/Fragile_base_class). In short words: "The programmer cannot determine whether a base class change is safe simply by examining in isolation the methods of the base class."
2. Move method calls to smaller local classes and store them as properties can make a whole difference when the base class gets big;
3. It's fine to consider two step initialization in some cases (constructor and init)

### Structure


#### The base class:
```
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
```

#### The Derived Classes
```
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
```

#### Generic Pooler for Pure Csharp Classes 

References:
1. Book [Game Programmings Patterns](https://gameprogrammingpatterns.com/subclass-sandbox.html)
2. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/SubclassSandbox%20Pattern)
3. Article [Habrador](https://www.habrador.com/tutorials/programming-patterns/11-subclass-sandbox-pattern/)
