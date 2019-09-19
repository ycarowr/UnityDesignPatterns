
# Command Pattern

## Some definitions:

"The command pattern is a behavioral design pattern in which an object is used to represent and encapsulate all the information needed to call a method at a later time. The information may include the name of the method, the object that owns the method and possible parameters for it."

"Encapsulate a request as an object, thereby letting users parameterize clients with different requests, queue or log requests, and support undoable operations." 

When to use it: 
1. Queues, sequences or steps of a process which may demand tracking;
2. Do and Undo operations;
3. Separate or decouple method of object from the invoker in order to make more flexible changes.

Notes:
1. Commands usually end up being also an example of sub class sandbox pattern;
2. Commands may also be part of a hierachical structure that brings the chain of responsability pattern;
3. Stateless commands very often can be a single static entity.

### Structure

#### Command

Here we have a [base class command class](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Command.cs) which defines a interface realized by concrete commands. 

All the concrete [Commands](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Commands) encapsute the parameters and the objects necessary for a future call to determined object.

#### Invoker
The concrete [Invoker](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Invoker/AnimationQueue.cs) class which has the responsability of invoking the commands.

Here some variations of invokers implementations:

The [Queue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/CommandQueue.cs) is First in First out structure that manipulates commands.

The [TimeredQueue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/TimeredCommandQueue.cs), although it works similar to the queue, it only dispatches commands only after a timer.

#### Actor 
The [Actor](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Actor/MotionEntity.cs) is one of the data encapsulated in each command for a future usage, its implementation depends completely of the application scope.

#### Client
The [Client](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Client/AnimationClient.cs), makes requests to the invoker call. like the actor implementation, works according to the application purposes.   

##### References: 
https://gameprogrammingpatterns.com/command.html
https://www.youtube.com/watch?v=7Pj5kAhVBlg&list=PLF206E906175C7E07&index=12
https://www.youtube.com/watch?v=9qA5kw8dcSU&list=PLDyBXGLPIsoNB6Hq0Y1fdT5146kTfxem4&index=26&t=830s
https://www.habrador.com/tutorials/programming-patterns/1-command-pattern/
https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/Command%20Pattern
https://github.com/Naphier/unity-design-patterns/tree/master/Assets/command%20pattern
https://sourcemaking.com/design_patterns/command
