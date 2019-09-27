
# State Machine 

## Definitions

"Allow an object to alter its behavior when its internal state changes."

"The state pattern, which closely resembles Strategy Pattern, is a behavioral software design pattern, also known as the objects for states pattern. This pattern is used in computer programming to encapsulate varying behavior for the same object based on its internal state."

When to use: 

1. You have an entity whose behavior changes based on some internal state.
2. That state can be rigidly divided into one of a relatively small number of distinct options.
3. The entity responds to a series of inputs or events over time.

Notes: 
1. Don't go fancy with FSMs because things can end up weird: "State machines help you untangle hairy code by enforcing a very constrained structure on it. All you’ve got is a fixed set of states, a single current state, and some hardcoded transitions."
2. It's fine to use more than one FSM, sometimes they will scratch each other with an ``if not state`` statement.
3. Enum implementations are much much lighter in memory.

### Structure

State: "The State interface declares the state-specific methods. These methods should make sense for all concrete states because you don’t want some of your states to have useless methods that will never be called."

Concrete States: "They provide their own implementations for the state-specific methods. To avoid duplication of similar code across multiple states, you may provide intermediate abstract classes that encapsulate some common behavior."

Context: "Context stores a reference to one of the concrete state objects and delegates to it all state-specific work. The context communicates with the state object via the state interface. The context exposes a setter for passing it a new state object."

### Implementation 

Implementation on a simple enemy [Patrol](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavioral/StateMachine/Examples/EnemyPatrol/Scripts/Patrol.cs) using an enumeration to illustrate the states:

```
//...
        Vector3 PointA { get; }
        Vector3 PointB { get; }
        State Current { get; set; }
        
        enum State
        {
            PointA,
            PointB,
            WalkA,
            WalkB
        }
        
        void GoTo(State next)
        {
            Current = next;
            Next();
        }
        
        //next state execution
        void Next()
        {
            switch (Current)
            {
                case State.PointA:
                    IdleRoutine = Handler.StartCoroutine(StayA());
                    break;
                case State.PointB:
                    IdleRoutine = Handler.StartCoroutine(StayB());
                    break;
                case State.WalkA:
                    WalkTowardsA();
                    break;
                case State.WalkB:
                    WalkTowardsB();
                    break;
            }
        }
// ...
```

The extendable more complex hierarchical implementation of [FSM](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavioral/StateMachine/Structure/BaseStateMachine.cs) which can also behave as a PushDownAutomata and keep track of the previous states. Due the stack and the register allocations this implementation uses much more memory than the enum implementation.

[State Interface](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavioral/StateMachine/Structure/IState.cs): Define the states operations.
```
    public interface IState
    {
        bool IsInitialized { get; }
        void OnInitialize();
        void OnEnterState();
        void OnExitState();
        void OnUpdate();
        void OnClear();
    }
```
Context Example: A [turn based state machine](https://github.com/ycarowr/DesignPatterns/blob/master/Assets/Behavioral/StateMachine/Examples/TurnBasedFsm/Scripts/TurnBasedStateMachine.cs) to control the turn flow in a turn-based game.

```
    public class TurnBasedStateMachine : BaseStateMachine
    {
        readonly AiTurnState aiTurn = new AiTurnState();
        readonly EndGameState endGame = new EndGameState();
        readonly PlayerTurnState playerTurn = new PlayerTurnState();
        readonly StartGameState startGame = new StartGameState();
//...
//...
        public void PlayerTurn()
        {
            PushState(playerTurn);
        }

        public void AiTurn()
        {
            PushState(aiTurn);
        }

        public void StartGame()
        {
            PushState(startGame);
        }

        public void EndGame()
        {
            PushState(endGame);
        }
    }

```

[Concrete States](https://github.com/ycarowr/DesignPatterns/tree/master/Assets/Behavioral/StateMachine/Examples/TurnBasedFsm/Scripts): PlayerTurn, AiTurn, EndGame and StartGame are examples of States.

References:
1. Youtube [Derek Banas](https://www.youtube.com/watch?v=MGEx35FjBuo&list=PLF206E906175C7E07&index=20)
2. Youtube [Christopher Okhravi](https://www.youtube.com/watch?v=N12L5D78MAA&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc&index=17)
3. Book [Game Programmings Patterns](https://gameprogrammingpatterns.com/state.html)
4. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Behavioral%20Patterns/State%20Pattern)
5. Article [Habrador](https://www.habrador.com/tutorials/programming-patterns/6-state-pattern/)
6. Article [Source Making](https://sourcemaking.com/design_patterns/state)
7. Article [Guru](https://refactoring.guru/design-patterns/state)
8. UML [Java Design Patterns](https://java-design-patterns.com/patterns/state/)
