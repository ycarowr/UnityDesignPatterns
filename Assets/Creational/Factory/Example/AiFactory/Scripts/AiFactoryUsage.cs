using UnityEngine;

namespace Factory
{
    public class AiFactoryUsage : MonoBehaviour
    {
        AiBase[] players = new AiBase[4];
        
        void Awake()
        {
            Populate();
        }

        [Button]
        void Populate()
        {
            for (int i = 0; i < players.Length; i++)
                players[i] = AiFactory.GetRandom();
        }

        [Button]
        void DoPlayersMoves()
        {
            for (int i = 0; i < players.Length; i++)
            {
                Debug.Log("Player [" + i + "]");
                players[i].DoMove();
            }
        }
    }
}