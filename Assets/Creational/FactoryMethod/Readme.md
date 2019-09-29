
# Factory Method

## Definitions

"Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses."

"It's a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created." 

Notes: 
1. "The advantage of a Factory Method is that it can return the same instance multiple times, or can return a subclass rather than an object of that exact type."
2. "The Factory Method pattern suggests that you replace direct object construction calls (using the new operator) with calls to a special factory method."

When to use it:
1. when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
2. when you want to provide users of your library or framework with a way to extend its internal components
3. "when you want to save system resources by reusing existing objects instead of rebuilding them each time.", in this case the factory returns the same object multiple times saving a lot of memory.

### Structure

1. Factory: The Creator class declares the factory method that returns new product objects. It’s important that the return type of this method matches the product interface.
```
    public interface IFactory
    {
        IProduct Create();
    }
```
2. Product: The Product declares the interface, which is common to all objects that can be produced by the creator and its subclasses.
```
    public interface IProduct
    {
    }
```
3. Concrete Factories: Concrete Creators override the base factory method so it returns a different type of product.
```
    public class FactoryA : IFactory
    {
        public IProduct Create()
        {
            return new ProductA();
        }
    }

    public class FactoryB : IFactory
    {
        public IProduct Create()
        {
            return new ProductB();
        }
    }
```
4. Concrete Products: Concrete Products are different implementations of the product interface.
```
    public class ProductA : IProduct
    {
    }

    public class ProductB : IProduct
    {
    }
```

References:
1. Youtube [Derek Banas](https://www.youtube.com/watch?v=ub0DXaeV6hA&list=PLF206E906175C7E07&index=5)
2. Youtube [Christopher Okhravi](https://www.youtube.com/watch?v=EcFVTgRHJLM&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc&index=4)
3. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Factory%20Method%20Pattern)
4. Article [Source Making](https://sourcemaking.com/design_patterns/factory_method)
5. Article [Guru](https://refactoring.guru/design-patterns/factory-method)
