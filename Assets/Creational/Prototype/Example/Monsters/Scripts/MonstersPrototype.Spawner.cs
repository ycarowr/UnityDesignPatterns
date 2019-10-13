using System;

public partial class MonstersPrototype
{
    // A Generic Spawner
    public class Spawner<T> where T : Monster
    {
        public Spawner(T prototype) => Prototype = prototype;

        T Prototype { get; }

        public Monster SpawnMonster() => Prototype.Clone();
    }

    // An alternative Spawner class.
    public class Spawner
    {
        public Spawner(Func<Monster> callBack) => SpawnMonsterCall = callBack;

        Func<Monster> SpawnMonsterCall { get; }

        public Monster SpawnMonster() => SpawnMonsterCall.Invoke();
    }
}