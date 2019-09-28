using System;

namespace Factory
{
    /// <summary>
    ///     All types of AI.
    /// </summary>
    public enum AiArchetype
    {
        Random,
        Heal,
        Aggressive
    }

    /// <summary>
    ///     Create instances of Ai according to the provided type.
    /// </summary>
    public class AiFactory
    {
        public static AiBase CreateAi(AiArchetype type)
        {
            switch (type)
            {
                case AiArchetype.Random: return CreateAiRandom();
                case AiArchetype.Heal: return CreateAiHeal();
                case AiArchetype.Aggressive: return CreateAiAggressive();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public static AiHeal CreateAiHeal()
        {
            return new AiHeal();
        }

        public static AiAggressive CreateAiAggressive()
        {
            return new AiAggressive();
        }

        public static AiRandom CreateAiRandom()
        {
            return new AiRandom();
        }

        public static AiBase GetRandom()
        {
            var ais = new AiArchetype[]
            {
                AiArchetype.Heal,
                AiArchetype.Random,
                AiArchetype.Aggressive
            };
            var index = UnityEngine.Random.Range(0, ais.Length);
            return CreateAi(ais[index]);
        }
    }
}