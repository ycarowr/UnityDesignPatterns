using System.Collections.Generic;
using UnityEngine;

public partial class MonstersPrototype : MonoBehaviour
{
    //Prototypes
    static readonly Ghost ghostPrototype = new Ghost(10, 15);
    static readonly Demon demonPrototype = new Demon(20, 30, 40);
    readonly Spawner<Demon> demonSpawnerGen = new Spawner<Demon>(demonPrototype);
    readonly Spawner demonSpawnerLamb = new Spawner(demonPrototype.Clone);

    //Spawners with Generics
    readonly Spawner<Ghost> ghostSpawnerGen = new Spawner<Ghost>(ghostPrototype);

    //Spawners with Lambda
    readonly Spawner ghostSpawnerLamb = new Spawner(ghostPrototype.Clone);

    //Store monsters 
    readonly List<Monster> monsterRegister = new List<Monster>();

    [Button]
    void SpawnDemons()
    {
        monsterRegister.Add(demonSpawnerGen.SpawnMonster());
        monsterRegister.Add(demonSpawnerLamb.SpawnMonster());
        PrintMonsters();
    }

    [Button]
    void SpawnGhosts()
    {
        monsterRegister.Add(ghostSpawnerGen.SpawnMonster());
        monsterRegister.Add(ghostSpawnerLamb.SpawnMonster());
        PrintMonsters();
    }

    void PrintMonsters()
    {
        for (var i = 0; i < monsterRegister.Count; ++i)
            Debug.Log("Index [" + i + "]: " + monsterRegister[i].GetType());
    }
}