using UnityEngine;

namespace Factory
{
    /// <summary>
    ///     This AI perform heal or damage.
    /// </summary>
    public class AiRandom : AiBase
    {
        const string Attack = "Attack!";
        const string Heal = "Heal!";
        public override string Move => Random.Range(0f, 1f) > 0.5f ? Attack : Heal;
    }
}