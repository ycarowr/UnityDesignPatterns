
# Abstract Factory

## Definitions

"It's a creational design pattern that lets you produce families of related objects without specifying their concrete classes."

"A hierarchy that encapsulates: many possible "platforms", and the construction of a suite of "products"" 

Notes: 
1. "The advantage of a Factory Method is that it can return the same instance multiple times, or can return a subclass rather than an object of that exact type."
2. "The Factory Method pattern suggests that you replace direct object construction calls (using the new operator) with calls to a special factory method."

When to use it:
1. when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
2. when you want to provide users of your library or framework with a way to extend its internal components
3. "when you want to save system resources by reusing existing objects instead of rebuilding them each time.", in this case the factory returns the same object multiple times saving a lot of memory.

### Structure

1. [Abstract Products](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Creational/AbstractFactory/UiSystemPlatformsFactory/Scripts/UiSystemPlatformsFactoryUsage.Products.cs): these are interfaces for a set of related products, or a product family. In this case, UI components.
```
        // Product A
        public interface IInput
        {
            KeyCode Jump { get; }
            KeyCode Attack { get; }
            KeyCode Block { get; }
            KeyCode PowerUp { get; }
        }

        // Product B
        public interface IWindow
        {
            string Name { get; }
        }

        // Product C
        public interface IButton
        {
            string Name { get; }
        }
```
2. [Concrete Products](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Creational/AbstractFactory/UiSystemPlatformsFactory/Scripts/UiSystemPlatformsFactoryUsage.ConcreteProducts.cs): are various implementations of abstract products, grouped by variants.
```
        //Concrete Product A1
        public class XboxInput : IInput
        {
            public KeyCode Jump => KeyCode.JoystickButton0;
            public KeyCode Attack => KeyCode.JoystickButton1;
            public KeyCode Block => KeyCode.JoystickButton2;
            public KeyCode PowerUp => KeyCode.JoystickButton3;
        }
        
        //Concrete Product A2
        public class Ps4Input : IInput
        {
            public KeyCode Jump => KeyCode.JoystickButton3;
            public KeyCode Attack => KeyCode.JoystickButton2;
            public KeyCode Block => KeyCode.JoystickButton1;
            public KeyCode PowerUp => KeyCode.JoystickButton0;
        }
        
        // ... more itens
```

3. [Abstract Factory](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Creational/AbstractFactory/UiSystemPlatformsFactory/Scripts/UiSystemPlatformsFactoryUsage.UiFactorySystem.cs): is an interface which declares methodsto create each of the abstracted products.
```
        public interface IUiFactorySystem
        {
            IInput CreateInputXbox();
            IButton CreateButtonXbox();
            IWindow CreateWindowXbox();

            IInput CreateInputPs4();
            IButton CreateButtonPs4();
            IWindow CreateWindowPs4();
        }
```
4. [Concrete Factories](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Creational/AbstractFactory/UiSystemPlatformsFactory/Scripts/UiSystemPlatformsFactoryUsage.Factories.cs): implement the creation methods of the abstract factory using the Factory Method Pattern.
```
        //Base concrete factory
        public class Ps4XboxBaseFactory<TPs4, TXbox, TBase> : IPs4XboxBaseFactory<TPs4, TXbox, TBase>
            where TPs4 : TBase, new()
            where TXbox : TBase, new()
        {
            public TPs4 CreatePs4()
            {
                return new TPs4();
            }

            public TXbox CreateXbox()
            {
                return new TXbox();
            }

            public TBase CreateSystem(RuntimePlatform platform)
            {
                if (platform != RuntimePlatform.PS4 && platform != RuntimePlatform.XboxOne)
                    Debug.LogError("Platform not supported: " + platform);

                if (platform == RuntimePlatform.PS4)
                    return CreatePs4();

                return CreateXbox();
            }
        }

        //Create a factory for the Input System
        public class InputSystemFactory : Ps4XboxBaseFactory<Ps4Input, XboxInput, IInput>
        {
        }

        //Create a factory for the Window System
        public class WindowSystemFactory : Ps4XboxBaseFactory<Ps4Window, XboxWindow, IWindow>
        {
        }

        //Create a factory for the Button System
        public class ButtonSystemFactory : Ps4XboxBaseFactory<Ps4Button, XboxButton, IButton>
        {
        }
```

5. [Concrete Abstract Factory](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Creational/AbstractFactory/UiSystemPlatformsFactory/Scripts/UiSystemPlatformsFactoryUsage.UiFactorySystem.cs): Factory that brings all the elements together.
```
        public class UiFactorySystem : IUiFactorySystem
        {
            readonly ButtonSystemFactory buttonFactory = new ButtonSystemFactory();
            readonly InputSystemFactory inputFactory = new InputSystemFactory();
            readonly WindowSystemFactory windowFactory = new WindowSystemFactory();
            
            //... implementation of the methods
        }
```

References:
1. Youtube [Derek Banas](https://www.youtube.com/watch?v=xbjAsdAK4xQ&list=PLF206E906175C7E07&index=6)
2. Youtube [Christopher Okhravi](https://www.youtube.com/watch?v=v-GiuMmsXj4&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc&index=5)
3. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Creational%20Patterns/Abstract%20Factory%20Pattern)
4. Article [Source Making](https://sourcemaking.com/design_patterns/abstract_factory)
5. Article [Guru](https://refactoring.guru/design-patterns/abstract-factory)
