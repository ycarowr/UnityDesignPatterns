
# Observer

## Definitions

Notes: 

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
4. Article [Habrador](https://www.habrador.com/tutorials/programming-patterns/3-observer-pattern/)
5. Article [Source Making](https://sourcemaking.com/design_patterns/factory_method)
6. Article [Guru](https://refactoring.guru/design-patterns/factory-method)
