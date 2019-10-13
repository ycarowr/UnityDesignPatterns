using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FactoryMethod
{
    #region Product

    public abstract class AiBase
    {
        public abstract string Move { get; }

        public void DoMove() => Debug.Log("My AI move is: " + Move);
    }

    #endregion

    #region Concrete Products 

    public class AiRandom : AiBase
    {
        const string Attack = "Attack!";
        const string Heal = "Heal!";
        public override string Move => Random.Range(0f, 1f) > 0.5f ? Attack : Heal;
    }

    public class AiHeal : AiBase
    {
        public override string Move => "Heal!!!";
    }

    public class AiAggressive : AiBase
    {
        public override string Move => "Attack!!!";
    }

    #endregion

    public enum AiArchetype
    {
        Random,
        Heal,
        Aggressive
    }

    #region Factory

    public abstract class AiBaseFactory
    {
        public abstract AiBase CreateAi(AiArchetype type);
        public abstract AiBase CreateRandom();
    }

    #endregion

    #region Concrete Factory

    public class AiFactory : AiBaseFactory
    {
        readonly AiAggressive aggressive = new AiAggressive();
        readonly AiHeal heal = new AiHeal();
        readonly AiRandom random = new AiRandom();

        public override AiBase CreateAi(AiArchetype type)
        {
            switch (type)
            {
                case AiArchetype.Random: return random;
                case AiArchetype.Heal: return heal;
                case AiArchetype.Aggressive: return aggressive;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public override AiBase CreateRandom()
        {
            var ais = new[]
            {
                AiArchetype.Heal,
                AiArchetype.Random,
                AiArchetype.Aggressive
            };
            var index = Random.Range(0, ais.Length);
            return CreateAi(ais[index]);
        }
    }

    #endregion
}