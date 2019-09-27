# Singleton Pattern Implementation

This folder contains two implementations of a pure C# Singleton Pattern. 

The first and simpler implementation has no multi thread lock, it creates the instance and initialize itself as soon as the constructor is called.

The second version creates the instance at the last minute, when the property is called (very often named lazy implementation). It might cause glinches during the game play if the Singleton does a heavy task at the initialization, but in the other hand, it makes the game load faster. 

You have to analise which implementation fits better you game.

Inside the Editor folder you will find some Unit Tests made in both Versions using the Unity3d Test Runner:
![alt text](https://github.com/ycarowr/Tools/blob/master/Assets/Scripts/Patterns/Singleton/Images/singleton%20test.GIF)

