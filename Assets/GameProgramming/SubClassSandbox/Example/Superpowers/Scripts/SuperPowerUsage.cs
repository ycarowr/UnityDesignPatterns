using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SubclassSandbox.Superpower
{
    public partial class SuperPowerUsage : MonoBehaviour
    {
        //Super powers
        readonly Superpower powerSkylaunch = new SkyLaunch();
        readonly Superpower powerStampede = new Stampede();
        readonly Superpower powerDash = new Dash();

        [Button]
        void ActivatePowers()
        {
            powerDash.Activate();
            powerStampede.Activate();
            powerSkylaunch.Activate();
        }
    }
}