
# Object Pooler

## Definitions

"Improve performance and memory use by reusing objects from a fixed pool instead of allocating and freeing them individually."

"Define a pool class that maintains a collection of reusable objects. Each object supports an “in use” query to tell if it is currently “alive”. When the pool is initialized, it creates the entire collection of objects up front (usually in a single contiguous allocation) and initializes them all to the “not in use” state.

When you want a new object, ask the pool for one. It finds an available object, initializes it to “in use”, and returns it. When the object is no longer needed, it is set back to the “not in use” state. This way, objects can be freely created and destroyed without needing to allocate memory or other resources." 

When to use: 
1. You need to frequently create and destroy objects.
2. Objects are similar in size.
3. Allocating objects on the heap is slow or could lead to memory fragmentation.
4. Each object encapsulates a resource such as a database or network connection that is expensive to acquire and could be reused.

Notes: 
1. Remember to restart the object when you release it back to the pool. A just released object is most likely "dirty" and it might cause weird behaviors when you pool the object once again, mainly if it is a visual element.
2. Reused objects are kept in memory. The Garbage Collector won't ever collect it.

### Structure

Pooler: It is the entity which keeps track of the collection of busy and free objects, it provides a method to Release and Get an a pooled object.

Pooled: An object that is frequently used by the application. 

Client: The entity that somehow interacts and manipulate the pooled objects. 

### Implementation 

#### Generic Pooler for Pure Csharp Classes

We can have many variations of the Object Pooler, it depends of the application necessities. 
Here you can find a more generic version for [Pure C# classes](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/GameProgramming/ObjectPooler/Structure/GenericPooler.cs). It can be used to pool objects and avoid the heap fragmentation or leaks.

```
    public class GenericPooler<T> where T : class, IPoolableObject, new()
    {
         //... more stuff
         
         public T Get()
         {
            //Do allocation or get a free object
         }
         
         public void Release(T released)
         {
            //Put the object into the free list and clear it
         }
         
         //... more stuff
    }

```

#### Prefab Pooler for GameObjects

The [PrefabPooler](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/GameProgramming/ObjectPooler/Structure/PrefabPooler.cs) is a bit more complex than the pure C# pooler because it pools GameObjects from the Unity3D engine. Those are most likely UI elements with models, particles, monobehaviors and other components that have an expensive cost for instantiation.

Here a gif illustrating the pooler usage:
![img](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/GameProgramming/ObjectPooler/Structure/Tests/Images/prefab.gif)

#### Tests:

Here some tests with the objet pooler: 

![omg](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/GameProgramming/ObjectPooler/Structure/Tests/Images/tdd%20generic%20pooler.GIF)



References:
1. Book [Game Programmings Patterns](https://gameprogrammingpatterns.com/object-pool.html)
2. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Object%20Pool%20Pattern)
3. Article [Source Making](https://sourcemaking.com/design_patterns/object_pool)
