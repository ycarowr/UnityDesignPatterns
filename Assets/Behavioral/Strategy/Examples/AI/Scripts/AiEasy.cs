using System.Collections.Generic;
using UnityEngine;

namespace Strategy
{
    public class AiEasy : IAiBehaviour
    {
        public void DestroyPiece(IGameState gameState)
        {
            Debug.Log("Destroyed piece in the EASY difficulty");
        }

        public void MovePiece(IGameState gameState)
        {
            Debug.Log("Moved piece in the EASY difficulty");
        }
    }
}