using UnityEngine;

namespace FactoryMethod
{
    public class AiFactoryUsage : MonoBehaviour
    {
        readonly AiFactory factory = new AiFactory();
        readonly AiBase[] players = new AiBase[4];

        void Awake() => Populate();

        [Button]
        void Populate()
        {
            for (var i = 0; i < players.Length; i++)
                players[i] = factory.CreateRandom();
        }

        [Button]
        void DoPlayersMoves()
        {
            for (var i = 0; i < players.Length; i++)
            {
                Debug.Log("Player [" + i + "]");
                players[i].DoMove();
            }
        }
    }
}