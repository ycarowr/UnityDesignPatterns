# Programming Design Patterns in Unity3D & C#

<details><summary> Why should you learn Design Patterns?
</summary>
<p>

Code Complete 2nd ed. by Steve McConnell says:

*Design patterns provide the cores of ready-made solutions that can be used to solve many of software’s most common problems. Some software problems require solutions that are derived from first principles. But most problems are similar to past problems, and those can be solved using similar solutions, or patterns* ...

*Patterns provide several benefits that fully custom design doesn’t: they reduce complexity by providing ready-made abstractions If you say, “This code uses a Factory Method to create instances of derived classes,” other programmers on your project will understand that your code involves a fairly rich set of inter-relationships and programming protocols, all of which are invoked when you refer to the design pattern of Factory Method. The Factory Method is a pattern that allows you to instantiate any class derived from a specific base class without needing to keep track of the individual derived classes anywhere but the Factory Method.*

*You don’t have to spell out every line of code for other programmers to understand the design approach found in your code. Patterns reduce errors by institutionalizing details of common solutions Software design problems contain nuances that emerge fully only after the problem has been solved once or twice (or three times, or four times, or...). Because patterns represent standardized ways of solving common problems, they embody the wisdom accumulated from years of attempting to solve those problems, and they also embody the corrections to the false attempts that people have made in solving those problems.*

*Using a design pattern is thus conceptually similar to using library code instead of writing your own. Sure, everybody has written a custom Quicksort a few times, but what are the odds that your custom version will be fully correct on the first try? Similarly, numerous design problems are similar enough to past problems that you’re better off using a prebuilt design solution than creating a novel solution.*

*Patterns provide heuristic value by suggesting design alternatives A designer who’s familiar with common patterns can easily run through a list of patterns and ask “Which of these patterns fits my design problem?” Cycling through a set of familiar alternatives is immeasurably easier than creating a custom design solution out of whole cloth. And the code arising from a familiar pattern will also be easier for readers of the code to understand than fully custom code would be.*

*Patterns streamline communication by moving the design dialog to a higher level In addition to their complexity-management benefit, design patterns can accelerate design discussions by allowing designers to think and discuss at a larger level of gran-
ularity. If you say “I can’t decide whether I should use a Creator or a Factory Method in this situation,” you’ve communicated a great deal with just a few words—as long as you and your listener are both familiar with those patterns. Imagine how much longer
it would take you to dive into the details of the code for a Creator pattern and the code for a Factory Method pattern and then compare and contrast the two approaches.*

*Patterns are familiar to most experienced programmers, and assigning recognizable names to them supports efficient and effective com-
munication about them.*

*One potential trap with patterns is force-fitting code to use a pattern. In some cases, shifting code slightly to conform to a well-recognized pattern will improve understandability of the code. But if the code has to be shifted too far, forcing it to look like a standard pattern can sometimes increase complexity.*

*Another potential trap with patterns is feature-itis: using a pattern because of a desire to try out a pattern rather than because the pattern is an appropriate design solution. Overall, design patterns are a powerful tool for managing complexity."*

</p>
</details>


The repository contains a variety of Design Patterns with a basic description, when to use it, notes, the code structure and examples. 

Most of the of references are listed on the bottom of this page, as well as more specific references are listed in each pattern description.

### Behavioral Patterns
  1. [Command](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavioral/Command)
  2. [Observer](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavioral/Observer)
  3. [State Machine](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavioral/StateMachine)
  4. [Strategy](https://github.com/ycarowr/UnityDesignPatterns/tree/master/Assets/Behavioral/Strategy)

### Creational Patterns
  1. [Abstract Factory](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Creational/AbstractFactory)
  2. [Factory Method](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Creational/FactoryMethod)
  3. [Singleton](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Creational/Singleton)
  4. [Prototype](https://github.com/ycarowr/Unity-Design-Patterns/tree/master/Assets/Creational/Prototype)

### Game Programming Patterns
  1. [Object Pool](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/GameProgramming/ObjectPooler)
  2. [Subclass Sandbox](https://github.com/ycarowr/Unity-Design-Patterns/tree/master/Assets/GameProgramming/SubClassSandbox)
  
### Structural Patterns
  1. [Composite](https://github.com/ycarowr/Unity-Design-Patterns/tree/master/Assets/Structural/Composite)

### References

1. Youtube Playlist [Christopher Okhravi](https://www.youtube.com/playlist?list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc)
2. Youtube Playlist [Derek Banas](https://www.youtube.com/playlist?list=PLF206E906175C7E07)
3. Bob Nystrom [Game Programmings Patterns](https://gameprogrammingpatterns.com/contents.html)
4. Github examples in Unity [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern)
5. Github examples in Unity [Rivello](https://github.com/srivello/UnityDesignPatterns)
6. Github examples in Unity [Naphier](https://github.com/Naphier/unity-design-patterns)
6. Quick look, UML and examples [Source Making](https://sourcemaking.com/design_patterns)
7. Quick look, UML and examples [Guru](https://refactoring.guru/design-patterns)
8. Quick look and examples [Habrador](https://www.habrador.com/tutorials/programming-patterns)
