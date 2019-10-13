using UnityEngine;

namespace SubclassSandbox.Superpower
{
    public partial class SuperPowerUsage
    {
        #region Base Class

        public enum SoundID
        {
            SoundSkyLaunch,
            SoundStampede,
            SoundDash
        }

        public enum ParticleType
        {
            ParticleSkyLaunch,
            ParticlesStampede,
            SoundDash
        }

        public abstract class Superpower
        {
            public abstract void Activate();

            protected void PlaySound(SoundID soundId, float volume) =>
                Debug.Log(GetType() + " Played sound " + soundId + " with volume " + volume);

            protected void Move(Vector3 amount) => Debug.Log(GetType() + " Moved " + amount);

            protected void SpawnParticles(ParticleType type, int count) =>
                Debug.Log(GetType() + " Spawned " + count + " particles of type " + type);
        }

        #endregion
    }
}