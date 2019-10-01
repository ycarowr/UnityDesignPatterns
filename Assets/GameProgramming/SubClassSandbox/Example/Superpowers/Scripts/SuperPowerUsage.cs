using UnityEngine;

namespace SubclassSandbox.Superpower
{
    public partial class SuperPowerUsage : MonoBehaviour
    {
        readonly Superpower powerDash = new Dash();

        //Super powers
        readonly Superpower powerSkylaunch = new SkyLaunch();
        readonly Superpower powerStampede = new Stampede();

        [Button]
        void ActivatePowers()
        {
            powerDash.Activate();
            powerStampede.Activate();
            powerSkylaunch.Activate();
        }
    }
}