using UnityEngine;

namespace SubclassSandbox.Superpower
{
    public partial class SuperPowerUsage
    {
        #region Subclasses

        //Sub class power 
        public class SkyLaunch : Superpower
        {
            public override void Activate()
            {
                const int volume = 1;
                PlaySound(SoundID.SoundSkyLaunch, volume);

                const int pCount = 10;
                SpawnParticles(ParticleType.ParticleSkyLaunch, pCount);

                var amount = new Vector3(0, 0, 20);
                Move(amount);
            }
        }


        //Sub class power B
        public class Stampede : Superpower
        {
            public override void Activate()
            {
                const int volume = 1;
                PlaySound(SoundID.SoundStampede, volume);

                const int pCount = 5;
                SpawnParticles(ParticleType.ParticlesStampede, pCount);
            }
        }

        //Sub class power C
        public class Dash : Superpower
        {
            public override void Activate()
            {
                const int volume = 1;
                PlaySound(SoundID.SoundDash, volume);

                const int pCount = 5;
                SpawnParticles(ParticleType.SoundDash, pCount);

                const int distance = 30;
                var amount = Vector3.forward * distance;
                Move(amount);
            }
        }

        #endregion
    }
}