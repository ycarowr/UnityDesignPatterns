using UnityEngine;

namespace Prototype.PrototypeLess
{
    public enum Element
    {
        Cold,
        Poison,
        Fire,
        Light
    }

    public enum Spell
    {
        Fireball,
        LightningBolt
    }

    public enum Attack
    {
        ShortBow
    }

    [CreateAssetMenu(menuName = "Prototypeless Data/Goblin")]
    public class GoblinData : ScriptableObject
    {
        [SerializeField] Attack[] attacks;
        [SerializeField] int maxHealth;
        [SerializeField] int minHealth;

        [SerializeField] string monsterName;
        [SerializeField] Element[] resists;
        [SerializeField] Spell[] spells;
        [SerializeField] Element[] weaknesses;
        
        //-------------------------------------------------------------------------------------------------------------

        #region Properties
        
        public string Name => monsterName;

        public int MinHealth => MinHealth;

        public int MaxHealth => MaxHealth;

        public Element[] Resists => Resists;

        public Element[] Weaknesses => Weaknesses;

        public Spell[] Spells => Spells;

        public Attack[] Attacks => Attacks;
        
        #endregion
    }
}