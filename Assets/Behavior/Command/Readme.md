
# Command Pattern

## Definition:
The command pattern is a behavioral design pattern in which an object is used to represent and encapsulate all the information needed to call a method at a later time. The information may include the name of the method, the object that owns the method and possible parameters for it. 

### Structure

A [base class command class](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Command.cs) defines a interface realized by concrete commands. 

#### Command
All [Commands](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Commands) encapsute data in order to dispatch a method from an object.
#### Invoker
The concrete [Invoker](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Invoker/AnimationQueue.cs) class which has the responsability of invoking the commands.

Here some templates of useful variations of invokers implementations.    
The [Queue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/CommandQueue.cs) is First in First out structure that manipulates commands.

The [TimeredQueue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/TimeredCommandQueue.cs) works similar to the queue, however it works according to the time. It dispatches a second command only after the first one is finished.

#### Actor 
The [Actor](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Actor/MotionEntity.cs) is the target of the commands. It is encapsulated inside each command for a future usage, its depends completely of the application scope.
#### Client
The [Client](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Client/AnimationClient.cs), like the actor implementation, works according to the application.   

##### References: 
https://gameprogrammingpatterns.com/command.html
https://www.youtube.com/watch?v=7Pj5kAhVBlg&list=PLF206E906175C7E07&index=12
https://www.youtube.com/watch?v=9qA5kw8dcSU&list=PLDyBXGLPIsoNB6Hq0Y1fdT5146kTfxem4&index=26&t=830s
https://www.habrador.com/tutorials/programming-patterns/1-command-pattern/
