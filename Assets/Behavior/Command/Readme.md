
# Command Pattern

## Definition:
The command pattern is a behavioral design pattern in which an object is used to represent and encapsulate all the information needed to call a method at a later time. The information may include the name of the method, the object that owns the method and possible parameters for it. 

### Structure

[Base](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Command.cs)
[Queue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/CommandQueue.cs)
[TimeredQueue](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Structure/Tools/TimeredCommandQueue.cs)

#### Command
[Commands](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Commands)
#### Invoker
[Invoker](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Invoker/AnimationQueue.cs)
#### Actor 
[Actor](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Actor/MotionEntity.cs)
#### Client
[Client](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavior/Command/Examples/AnimationQueue/Scripts/Client/AnimationClient.cs)

##### References: 
https://gameprogrammingpatterns.com/command.html
https://www.youtube.com/watch?v=7Pj5kAhVBlg&list=PLF206E906175C7E07&index=12
https://www.youtube.com/watch?v=9qA5kw8dcSU&list=PLDyBXGLPIsoNB6Hq0Y1fdT5146kTfxem4&index=26&t=830s
https://www.habrador.com/tutorials/programming-patterns/1-command-pattern/
