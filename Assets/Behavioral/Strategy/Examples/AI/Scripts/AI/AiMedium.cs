using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Strategy
{
    public class AiMedium : IAiBehaviour
    {
        public void DestroyPiece(IGameState gameState)
        {
            Debug.Log("Destroyed piece in the MEDIUM difficulty");
        }

        public void MovePiece(IGameState gameState)
        {
            Debug.Log("Moved piece in the MEDIUM difficulty");
        }
    }
}