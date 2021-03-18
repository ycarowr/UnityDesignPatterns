using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Strategy
{
    /*
     * The class provides the game state to different types of AI to
     * interact with. Therefore making them interchangeable and easy to test.
     */
    public class AiComponent : MonoBehaviour
    {
        private enum AiType
        {
            Easy = 0, 
            Medium = 1, 
            Hard = 2 
        }

        private readonly IGameState _gameState = new Game();
        private readonly AiEasy _aiEasy = new AiEasy();
        private readonly AiMedium _aiMedium = new AiMedium();
        private readonly AiHard _aiHard = new AiHard();
        
        [SerializeField] private AiType current = AiType.Medium;
        
        [Button]
        public void MovePiece()
        {
            switch (current)
            {
                case AiType.Easy:
                    _aiEasy.MovePiece(_gameState);
                    break;
                case AiType.Medium:
                    _aiMedium.MovePiece(_gameState);
                    break;
                case AiType.Hard:
                    _aiHard.MovePiece(_gameState);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        [Button]
        public void DestroyPiece()
        {
            switch (current)
            {
                case AiType.Easy:
                    _aiEasy.DestroyPiece(_gameState);
                    break;
                case AiType.Medium:
                    _aiMedium.DestroyPiece(_gameState);
                    break;
                case AiType.Hard:
                    _aiHard.DestroyPiece(_gameState);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }   
        }
    }
}