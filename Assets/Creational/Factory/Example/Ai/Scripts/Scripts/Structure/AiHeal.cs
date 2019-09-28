namespace Factory
{
    /// <summary>
    ///     This AI always heals itself... and never wins.
    /// </summary>
    public class AiHeal : AiBase
    {
        public override string Move => "Heal!!!";
    }
}