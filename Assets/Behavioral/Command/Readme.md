
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

The [Concrete Commands](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Commands) realize the implementation of the base class as well as encapsute the necessary data to call the method _Execute()_.

#### Invoker
The [Invoker](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Invoker/AnimationQueue.cs) class has the responsability of invoking the commands.

Here are some variations of invokers implementations:
The [Queue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/CommandQueue.cs) is First in First out structure that manipulates commands. And the [TimeredQueue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/TimeredCommandQueue.cs), although it works in a similar way but it only dispatches commands only after an amount of time.

#### Actor 
An object or [Actor](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Actor/MotionEntity.cs) and a method with the apropriated parameters are the data encapsulated in each command for a future usage, its implementation depends completely of the application scope.

#### Client
The [Client](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Client/AnimationClient.cs), makes requests to the invoker call in order to create and dispatch commands. Like the actor implementation, works according to the application purposes.   

##### References: 
[Game Programming Patterns Book](https://gameprogrammingpatterns.com/command.html)
[Source Making Article](https://sourcemaking.com/design_patterns/command)
[Habrador Article](https://www.habrador.com/tutorials/programming-patterns/1-command-pattern/)
[Qian Mo Github](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Command%20Pattern)
[Naphier Github](https://github.com/Naphier/unity-design-patterns/tree/master/Assets/command%20pattern)
[Christopher Okhravi Youtube](https://www.youtube.com/watch?v=9qA5kw8dcSU&list=PLDyBXGLPIsoNB6Hq0Y1fdT5146kTfxem4&index=26&t=830s)
[Derek Banas Youtube](https://www.youtube.com/watch?v=7Pj5kAhVBlg&list=PLF206E906175C7E07&index=12)

