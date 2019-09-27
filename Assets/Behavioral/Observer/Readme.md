
# Observer

## Definitions

"The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods."

"Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically."

"Encapsulate the core (or common or engine) components in a Subject abstraction, and the variable (or optional or user interface) components in an Observer hierarchy."

"The "View" part of Model-View-Controller."

### Structure

Subject: Is the observed object and target of a listener, usually when this object changes the state the interested listeners have to be notified.

Listener: Is the observer of the subject, waits for any change on the interested object.

Publisher: Usually is the object resposible to notify the listeners, it most likely has some sort of register to keep track of the listers and what they are watching.


The implementation using Csharp native ``event`` sintax, which allows to create a subject inside a class and add subscribers from outside classes.

Implementation using [Actions](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavioral/Observer/Structure/ObserverCsharpAction.cs) 
```
  //...
        public static event Action OnStartGame = () => { };
        public static event Action<int, float, bool> OnEndGame = (a, b, c) => { };
        
        static void OnEndGame()
        {
            var a = 1;
            float b = 2;
            var c = true;
            
            //dispatches end game event
            OnEndGame(a, b, c);
        }
  //...
```

Implementation using [Delegates](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavioral/Observer/Structure/ObserverCsharpDelegates.cs)

```
//...
        public delegate void EndGameDelegate(int a, float b, bool c);
        public static event EndGameDelegate OnEndGame = (a, b, c) => { };
  
        static void EndGame()
        {
            var a = 1;
            float b = 2;
            var c = true;
            
            //dispatches end game event
            OnEndGame(a, b, c);
        }
//...
```


An alternative implementation that is more generic and universal. The [Publisher](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavioral/Observer/Structure/Observer.cs) class keeps track of subjects, listeners and has holds the _Notify()_ method which is dispatched from other client classes. 

```
        public void AddListener(IListener listener)
        {
            //... adds the listener to the list
        }

        public void RemoveListener(IListener listener)
        {
           //... remove a listener from the list
        }

        public void RemoveSubject(Type subject)
        {
            // ... remove a subject and all its listeners
        }
        
        public void Notify<T1>(Action<T1> subject) where T1 : class
        {
          // ... iterates over the listeners of a subject and notifies all of them 
        }
```

Notes: 
1. Rememer to unsubscribe
2. Remove the subscription
3. Don't do the following mess: the "observer A" observes the "observer B" which is observing the "observer C"
4. Please, write the code to unsubscribe

References:
1. Youtube [Derek Banas](https://www.youtube.com/watch?v=wiQdrH2YpT4&list=PLF206E906175C7E07&index=5&t=0s)
2. Youtube [Christopher Okhravi](https://www.youtube.com/watch?v=_BpmfnqjgzQ&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc&index=3&t=12s)
3. Book [Game Programmings Patterns](https://gameprogrammingpatterns.com/observer.html)
4. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Observer%20Pattern)
5. Article [Habrador](https://www.habrador.com/tutorials/programming-patterns/3-observer-pattern/)
6. Article [Source Making](https://sourcemaking.com/design_patterns/observer)
7. Article [Guru](https://refactoring.guru/design-patterns/observer)
8. UML [Java Design Patterns](https://java-design-patterns.com/patterns/observer/)
