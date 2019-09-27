using System.Collections;
using System.Collections.Generic;
using ExampleStateMachine;
using UnityEngine;

public class TurnBasedController : MonoBehaviour
{
    TurnBasedStateMachine TurnBasedFsm = new TurnBasedStateMachine();

    void Awake()
    {
        TurnBasedFsm.Initialize();
    }

    /*
       Avoiding the updating the Fsm because it is not necessary here.
    void Update()
    {
        TurnBasedFsm.Update();
    }
    */
    
    [Button]
    public void PlayerTurn()
    {
        TurnBasedFsm.PlayerTurn();
    }
        
    [Button]
    public void AiTurn()
    {
        TurnBasedFsm.AiTurn();
    }
    
    [Button]
    public void StartGame()
    {
        TurnBasedFsm.StartGame();
    }
    
    [Button]
    public void EndGame()
    {
        TurnBasedFsm.EndGame();
    }
}
