
# Prototype

## Definitions

"Prototype is a creational design pattern that allows cloning objects, even complex ones, without coupling to their specific classes."

When to use it:
1. Use the pattern when your code shouldn’t depend on concrete classes of objects you need to copy.
2. Use the pattern when you want to reduce the number of subclasses that only differ in the way they initialize their respective objects. 

Notes: 
1. Does it do a deep clone or shallow one? In other words, if a demon is holding a pitchfork, does cloning the demon clone the pitchfork too?
2. Try to use Spawner classes and avoid repeateable code inside each class of each clone.
3. Use the same concept for data modeling (static data) combining it with Scriptable Objects, JSON, etc.

### Structure

1. Prototype: The Prototype is the interface that declares the cloning method.
```
    public interface ICloneable
    {
        ICloneable Clone();
    }
```
2. The Concrete Prototype: it implements the cloning method and it has to resolve all the intricacies related to it.
```
    public class ConcretePrototype : ICloneable
    {
        public string Name;

        public ConcretePrototype(ConcretePrototype prototype)
        {
            this.Name = prototype.Name;
        }
        
        public ICloneable Clone()
        {
            return new ConcretePrototype(this);
        }
    }
```
3. Sub classes of the Prototyped class work in the same way:
```
    public class AnotherPrototype : ConcretePrototype
    {
        public int Age;
        public AnotherPrototype(AnotherPrototype prototype) : base(prototype)
        {
            Age = prototype.Age;
        }
        
        public override ICloneable Clone()
        {
            return new AnotherPrototype(this);
        }
    }
```

### Prototype in data modeling:

Don't do this, it is a lot of repetition and hard to manage:
```
{
  "name": "goblin grunt",
  "minHealth": 20,
  "maxHealth": 30,
  "resists": ["cold", "poison"],
  "weaknesses": ["fire", "light"]
}

{
  "name": "goblin wizard",
  "minHealth": 20,
  "maxHealth": 30,
  "resists": ["cold", "poison"],
  "weaknesses": ["fire", "light"],
  "spells": ["fire ball", "lightning bolt"]
}

{
  "name": "goblin archer",
  "minHealth": 20,
  "maxHealth": 30,
  "resists": ["cold", "poison"],
  "weaknesses": ["fire", "light"],
  "attacks": ["short bow"]
}
```

Try the following instead, its much less stuff:
```
{
  "name": "goblin grunt",
  "minHealth": 20,
  "maxHealth": 30,
  "resists": ["cold", "poison"],
  "weaknesses": ["fire", "light"]
}

{
  "name": "goblin wizard",
  "prototype": "goblin grunt",
  "spells": ["fire ball", "lightning bolt"]
}

{
  "name": "goblin archer",
  "prototype": "goblin grunt",
  "attacks": ["short bow"]
}
```
"It makes the "prototype" a piece of metadata instead of data. Goblins have warty green skin and yellow teeth. They don’t have prototypes. Prototypes are a property of the data object representing the goblin, and not the goblin itself."


References:
1. Youtube [Derek Banas](https://www.youtube.com/watch?v=AFbZhRL0Uz8&list=PLF206E906175C7E07&index=10&t=0s)
2. Book [Game Programming Patterns](https://gameprogrammingpatterns.com/prototype.html)
3. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Prototype%20Pattern)
4. Article,  [Source Making](https://sourcemaking.com/design_patterns/prototype)
5. Article, code examples [Guru](https://refactoring.guru/design-patterns/prototype)
