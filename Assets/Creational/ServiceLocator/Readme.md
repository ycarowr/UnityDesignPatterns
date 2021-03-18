
# Service Locator

Intent: Provide a global point of access to a service without coupling users to the concrete class that implements it.

When to use it: 
- Reduce coupling between implementation and client objects.
- Similar aspects as Singleton, used to provide global access.

Problems:
- The services have to be located. Not modular. Classes will rely in the Locator to work properly.
- Is global. Any other class can poke it. 
- Makes testing harder.

Notes: 
- Not use it extensively. Static and Singleton problems. 
- Give the preference to pass services in instead using it (using constructor)
- What happens if the service can’t be located? Use it alongside NullObject Pattern?
- Services don't know who is locating them. It might be considered in some implementations.

References:
1. Book [Game Programming Patterns](https://gameprogrammingpatterns.com/service-locator.html)
2. Github [Qian Mo](https://github.com/QianMo/Unity-Design-Pattern/tree/master/Assets/Game%20Programming%20Patterns/Service%20Locator%20Pattern)
