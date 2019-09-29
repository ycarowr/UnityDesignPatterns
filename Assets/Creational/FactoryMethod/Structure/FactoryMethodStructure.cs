namespace FactoryMethod
{
    // The Creator class declares the factory method that returns new product objects.
    // It’s important that the return type of this method matches the product interface.    
    public interface IFactory
    {
        IProduct Create();
    }

    // The Product declares the interface, which is common to all objects that can be produced by the creator and its subclasses.
    public interface IProduct
    {
    }

    #region Concrete Products

    // Concrete Products are different implementations of the product interface.

    public class ProductA : IProduct
    {
    }

    public class ProductB : IProduct
    {
    }

    #endregion

    #region Concrete Creators

    // Concrete Creators override the base factory method so it returns a different type of product.

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

    #endregion
}