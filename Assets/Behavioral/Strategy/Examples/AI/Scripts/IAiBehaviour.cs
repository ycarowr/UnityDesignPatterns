using System.Collections.Generic;

namespace Strategy
{
    public interface IAiBehaviour
    {
        void DestroyPiece(IGameState gameState);
        void MovePiece(IGameState gameState);
    }
}