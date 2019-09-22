# Generic C# Object Pooler

This is a generic object pooler that allows you to manipulate any pure c# class implementing the interface IPoolableObject.

The main purpose of this class is to manage how many instances of a class you have in memory, that way avoiding possible memory leaks and consequently glinches during the game because of a smash of the garbage collector.

Inside the Editor folder you will find Unit Tests and some practice of Test Driven Development using the pooler class:

![alt text](https://github.com/ycarowr/Tools/blob/master/Assets/Scripts/Patterns/GenericPooler/Images/tdd%20generic%20pooler.GIF)

