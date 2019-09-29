using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.Prototype
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

    [CreateAssetMenu(menuName = "Prototype Data/Goblin")]
    public class GoblinData : ScriptableObject
    {
        public GoblinData Prototype => prototype;
        public string MonsterName => monsterName;
        public int MinHealth => prototype.minHealth + minHealth;
        public int MaxHealth => prototype.maxHealth + maxHealth;
        public Element[] Resists => prototype.resists;
        public Element[] Weaknesses => prototype.weaknesses;
        public Spell[] Spells => spells;
        public Attack[] Attacks => attacks;

        [SerializeField] GoblinData prototype;
        [SerializeField] string monsterName;
        [SerializeField] int minHealth;
        [SerializeField] int maxHealth;
        [SerializeField] Element[] resists;
        [SerializeField] Element[] weaknesses;
        [SerializeField] Spell[] spells;
        [SerializeField] Attack[] attacks;
    }
}

