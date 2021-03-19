
# Type Object

## Definition

"Define a type object class and a typed object class. Each type object instance represents a different logical type. Each typed object stores a reference to the type object that describes its type."

Basically replace overriden methods by an object that wraps the behavior/data. And use it for all instances that share it. It is another way to move away from inheritance.

## When use it

1. You don’t know what types you will need up front
2. You want to be able to modify or add new types without having to recompile or change code.

### Notes
- You move the Type from Code to Data. The flexibility is good, but you lose some things by hoisting your types into data.
- We need to make sure the Types are loaded in memory because they are now objects, and not part of the language done in compilation time.
- It is much more complex to add new behaviors to specific Types because we don't have code (this point not valid for Scriptable Objects).  

References:
1. Book [Game Programmings Patterns](https://gameprogrammingpatterns.com/type-object.html)
2. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Type%20Object%20Pattern)
