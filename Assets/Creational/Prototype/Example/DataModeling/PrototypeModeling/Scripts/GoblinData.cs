using UnityEngine;

namespace Prototype.Prototype
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

    [CreateAssetMenu(menuName = "Prototype Data/Goblin")]
    public class GoblinData : ScriptableObject
    {
        // Goblin Data

        [SerializeField] Attack[] attacks;
        [SerializeField] int maxHealth;
        [SerializeField] int minHealth;
        [SerializeField] string monsterName;

        [SerializeField] GoblinData prototype;
        [SerializeField] Element[] resists;
        [SerializeField] Spell[] spells;
        [SerializeField] Element[] weaknesses;

        //-------------------------------------------------------------------------------------------------------------

        #region Properties

        // Properties fetch the data from the prototyped entity.
        // Which means that all goblins share that data.
        public int MinHealth => prototype.minHealth + minHealth;
        public int MaxHealth => prototype.maxHealth + maxHealth;
        public Element[] Resists => prototype.resists;
        public Element[] Weaknesses => prototype.weaknesses;


        public string MonsterName => monsterName;
        public Spell[] Spells => spells;
        public Attack[] Attacks => attacks;

        #endregion
    }
}