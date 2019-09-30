
# Command Pattern

## Some definitions:

"The command pattern is a behavioral design pattern in which an object is used to represent and encapsulate all the information needed to call a method at a later time. The information may include the name of the method, the object that owns the method and possible parameters for it."

"Encapsulate a request as an object, thereby letting users parameterize clients with different requests, queue or log requests, and support undoable operations." 

When to use it: 
1. Queues, sequences or steps of a process which may demand tracking;
2. Do and Undo operations;
3. Decouple method of object from the invoker in order to make more flexible changes.

Notes:
1. Commands can be an example of sub class sandbox pattern;
2. Commands may play a role in the chain of responsability pattern;
3. Stateless commands very often can be a single static entity.

### Structure

#### Command

A base [Command](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Command.cs) defines a interface to assure the existence of the methods _Execute()_ and _Unexecute()_. 

```
    /// <summary>
    ///     The command base class.
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
    }
```

The [Concrete Commands](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Commands) realize the implementation of the base class as well as encapsute the necessary data to call the method _Execute()_.

```
    /// <summary>
    ///     A command to move a determined object.
    /// </summary>
    public class MoveObject : BaseMotionAnimation
    {
        public MoveObject(IMotion entity, Vector3 amount) : base(entity)
        {
            Start = MotionEntity.transform.position;
            Amount = amount;
        }

        public Vector3 Start { get; }
        public Vector3 Amount { get; }

        public override void Execute()
        {
            MotionEntity.Move(Start + Amount);
        }
    }
```

#### Invoker
The [Invoker](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Invoker/AnimationQueue.cs) class has the responsability to invoke commands.

```
        //...
        ///     Enqueues an animation based on its type.
        public void InvokeAnimation(AnimationType type)
        {
            switch (type)
            {
                case AnimationType.MoveLeft:
                    Enqueue(MoveLeft);
                    break;
                case AnimationType.MoveRight:
                    Enqueue(MoveRight);
                    break;
                case AnimationType.RotateLeft:
                    Enqueue(RotateLeft);
                    break;
                case AnimationType.RotateRight:
                    Enqueue(RotateRight);
                    break;
                case AnimationType.ScaleUp:
                    Enqueue(ScaleUp);
                    break;
                case AnimationType.ScaleDown:
                    Enqueue(ScaleDown);
                    break;
            }
        }
        //...
```

Here are some variations of invokers implementations:
1. The [Queue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/CommandQueue.cs) is First in First out structure that manipulates commands. 
2. [TimeredQueue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/TimeredCommandQueue.cs) works in a similar way, however it only dispatches commands only after an amount of time.

#### Actor 
An [Actor](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Actor/MotionEntity.cs), a method call and its parameters are the data encapsulated by the concrete commands. 
The implementation depends completely of the application scope, in this case, a motion object.

```
    //An object in the world 
    public interface IMotion
    {
        Transform transform { get; }
        void Move(Vector3 amount);
        void Scale(Vector3 amount);
        void Rotate(Vector3 amount);
    }
```

#### Client
The [Client](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Client/AnimationClient.cs), makes requests to the invoker to dispatch the commands.    

```
        //...
        void EnqueueMoveLeft()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.MoveLeft);
        }

        void EnqueueMoveRight()
        {
            AnimationQueue.InvokeAnimation(AnimationQueue.AnimationType.MoveRight);
        }
        //...
```

##### References: 
1. Book [Game Programming Patterns](https://gameprogrammingpatterns.com/command.html)
2. Article [Source Making](https://sourcemaking.com/design_patterns/command)
3. Article [Habrador](https://www.habrador.com/tutorials/programming-patterns/1-command-pattern/)
4. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Command%20Pattern)
5. Github [Naphier](https://github.com/Naphier/unity-design-patterns/tree/master/Assets/command%20pattern)
6. Youtube [Christopher Okhravi](https://www.youtube.com/watch?v=9qA5kw8dcSU&list=PLDyBXGLPIsoNB6Hq0Y1fdT5146kTfxem4&index=26&t=830s)
7. Youtube [Derek Banas](https://www.youtube.com/watch?v=7Pj5kAhVBlg&list=PLF206E906175C7E07&index=12)
8. UML [Java Design Patterns](https://java-design-patterns.com/patterns/command/)

