
# Composition - Component

## Definitions

"Allow a single entity to span multiple domains without coupling the domains to each other."

"Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects."

"Compose objects into tree structures to represent whole-part hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly."

When to use: 
1. You have a class that touches multiple domains which you want to keep decoupled from each other.
2. A class is getting massive and hard to work with.
3. You want to be able to define a variety of objects that share different capabilities, but using inheritance doesn’t 
let you pick the parts you want to reuse precisely enough.
4. It is an alternative to inheritence. Composition vs Inheritence?

Notes: 
1. The Component pattern adds a good bit of complexity over simply making a class and putting code in it.
2. Given the container object, first you have to get the component you want, then you can do what you need. 
In performance-critical inner loops, this pointer following may lead to poor performance.


### Structure

The *Component* interface describes operations that are common to both simple and complex elements of the tree.
```
        public interface IComponent
        {
            void Operate();
        }
```
The *Sub-Component* Subcomponents are basic elements of a tree that doesn’t have sub-elements. Also called leaf,
they end up doing most of the real work, since they don’t have anyone to delegate the work to.
```
        public class SubComponent : IComponent
        {
            public void Operate()
            {
                //Do some work.
            }
        }
```
The *Component* The Container is an element that has sub-elements: leaves or other containers. 
A container doesn’t know the concrete classes of its children. It works with all sub-elements only via the component interface. 
Upon receiving a request, a container delegates the work to its sub-elements, processes intermediate results and then returns the final result to the client.
```
        public class Component : IComponent
        {
            readonly List<IComponent> _components = new List<IComponent>();
            public void Operate()
            {
                foreach (var c in _components)
                    c.Operate();
            }

            public void AddComponent(IComponent c) => _components.Add(c);
            public void RemoveComponent(IComponent c) => _components.Remove(c);
            public IComponent GetComponent(int index) => _components[index];
        }
```

The *Client* works with all elements through the component interface. As a result, the client can work in the same way with both simple or complex elements of the tree.

References:
1. Youtube [Derek Banas](https://www.youtube.com/watch?v=2HUnoKyC9l0&list=PLF206E906175C7E07&index=19&t=0s)
2. Youtube [Christopher Okhravi](https://www.youtube.com/watch?v=EWDmWbJ4wRA&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc&index=15&t=965s)
3. Book [Game Programmings Patterns](https://gameprogrammingpatterns.com/component.html)
4. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Structural%20Patterns/Composite%20Pattern)
6. Article [Source Making](https://sourcemaking.com/design_patterns/composite)
7. Article [Guru](https://refactoring.guru/design-patterns/composite)
