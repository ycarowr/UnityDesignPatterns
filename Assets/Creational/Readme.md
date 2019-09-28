
# Singleton

## Definitions

"Ensure a class has one instance, and provide a global point of access to it."

When to use it: 
1. When you need to assure that only one instance has to be created;
2. WHen you want to provide global access to an object;

Bad things about Singletons: 
1. "In the short term, the Singleton pattern is relatively benign. Like many design choices, we pay the cost in the long term. Once we’ve cast a few unnecessary singletons into cold hard code, here’s the trouble we’ve bought ourselves."
2. They make it harder to reason about code.;
3. They encourage coupling;
4. They aren’t concurrency-friendly;
5. Lazy initialization might take the control away from you.

What to do instead:
1. Pass it in using constructor;
2. Get it from the base class;
3. Get it from something already global;
4. Service Locator Pattern.

### Implementation 

I've found three common ways to use singletons in Unity and the implementations are slightly different because of the Monobehaviors.

The first [Pure Csharp](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Creational/Singleton/PureCSharp/Singleton.cs) with lazy instatiation. If you don't need Monohaviors, use this version:

```
    public class Singleton<T> where T : class, new()
    {
        public static T Instance { get; private set; } = CreateInstance();
        
        static T CreateInstance()
        {
            return Instance ?? (Instance = new T()); 
        }
    }
```

The second implementation in a [Monobehavior](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Creational/Singleton/Monobehavior/SingletonMB.cs) class. I know we should avoid Monohaviors as much as possible, however, I think this type of Singleton still has his place in small projects. 


```
        public class SingletonMB<T> : MonoBehaviour where T : class
        {
            public static T Instance { get; private set; }
            //More stuff
        }
```

The Monobehavior initialization happens on the Awake method:
```
        //.. more stuff
        protected virtual void Awake()
        {
            if (Instance == null)
                Initialize();
            else if (Instance as SingletonMB<T> != this) 
                HandleDuplication();
        }
        
        void Initialize()
        {
            Instance = this as T;
            //sub classes have to override OnAwake
            OnAwake();
        }
        
        //.. more stuff
```


A third version can be found. I don't like this implementation because as you can tell, is persistent. If you destroy it
and some other context call the Persistent Singleton it instantiates once again and might cause glinches on the FPS.
```
        public class PersistentSingleton<T> : MonoBehaviour where T : Component
        {
            //.. more stuff
        
            static void CreateInstance()
            {
                var go = new GameObject(typeof(T).ToString());
                instance = go.AddComponent<T>();
            }
        
            //.. more stuff
        }

```

References:
1. Youtube [Derek Banas](https://www.youtube.com/watch?v=NZaXM67fxbs&list=PLF206E906175C7E07&index=7)
2. Youtube [Christopher Okhravi](https://www.youtube.com/watch?v=hUE_j6q0LTQ&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc&index=6)
3. Book [Game Programmings Patterns](https://gameprogrammingpatterns.com/singleton.html)
4. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Singleton%20Pattern)
5. Article [Source Making](https://sourcemaking.com/design_patterns/singleton)
6. Article [Guru](https://refactoring.guru/design-patterns/singleton)

Threads with people talking about singleton implementations:
1. https://csharpindepth.com/articles/singleton
2. https://stackoverflow.com/questions/2319075/generic-singletont
3. https://codereview.stackexchange.com/questions/10554/a-generic-singleton
