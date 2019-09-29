using System.Collections.Generic;
using UnityEngine;

public partial class MonstersPrototype : MonoBehaviour
{
    //Store monsters 
    readonly List<Monster> monsterRegister = new List<Monster>();
    
    //Prototypes
    static readonly Ghost ghostPrototype = new Ghost(10, 15);
    static readonly Demon demonPrototype = new Demon(20, 30, 40);
    
    //Spawners with Generics
    readonly Spawner<Ghost> ghostSpawnerGen = new Spawner<Ghost>(ghostPrototype);
    readonly Spawner<Demon> demonSpawnerGen = new Spawner<Demon>(demonPrototype);

    //Spawners with Lambda
    readonly Spawner ghostSpawnerLamb = new Spawner(ghostPrototype.Clone);
    readonly Spawner demonSpawnerLamb = new Spawner(demonPrototype.Clone);

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