using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
    public class AiHard : IAiBehaviour
    {
        public void DestroyPiece(IGameState gameState)
        {
            Debug.Log("Destroyed piece in the HARD difficulty");
        }

        public void MovePiece(IGameState gameState)
        {
            Debug.Log("Moved piece in the HARD difficulty");
        }
    }
}