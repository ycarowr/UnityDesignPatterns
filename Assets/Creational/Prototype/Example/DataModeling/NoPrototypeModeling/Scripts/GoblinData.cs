using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.PrototypeLess
{
    public enum Element
    {
        Cold, Poison, Fire, Light
    }

    public enum Spell
    {
        Fireball, LightningBolt
    }

    public enum Attack
    {
        ShortBow
    }

    [CreateAssetMenu(menuName = "Prototypeless Data/Goblin")]
    public class GoblinData : ScriptableObject
    {
        public string Name => monsterName;

        public int MinHealth => MinHealth;

        public int MaxHealth => MaxHealth;

        public Element[] Resists => Resists;

        public Element[] Weaknesses => Weaknesses;

        public Spell[] Spells => Spells;

        public Attack[] Attacks => Attacks;

        [SerializeField] string monsterName;
        [SerializeField] int minHealth;
        [SerializeField] int maxHealth;
        [SerializeField] Element[] resists;
        [SerializeField] Element[] weaknesses;
        [SerializeField] Spell[] spells;
        [SerializeField] Attack[] attacks;
    }
}

