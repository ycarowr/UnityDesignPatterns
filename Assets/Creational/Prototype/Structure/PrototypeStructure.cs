namespace Prototype
{
    //The Prototype interface declares the cloning methods. In most cases, it’s a single clone method.
    public interface ICloneable
    {
        ICloneable Clone();
    }

    //The Concrete Prototype class implements the cloning method. In addition to copying the original object’s data to the clone,
    //this method may also handle some edge cases of the cloning process related to cloning linked objects, untangling recursive dependencies, etc.
    public class ConcretePrototype : ICloneable
    {
        public string Name;

        public ConcretePrototype(ConcretePrototype prototype) => Name = prototype.Name;

        public virtual ICloneable Clone() => new ConcretePrototype(this);
    }

    public class AnotherPrototype : ConcretePrototype
    {
        public int Age;

        public AnotherPrototype(AnotherPrototype prototype) : base(prototype) => Age = prototype.Age;

        public override ICloneable Clone() => new AnotherPrototype(this);
    }
}