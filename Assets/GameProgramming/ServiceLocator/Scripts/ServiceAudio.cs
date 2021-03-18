using UnityEngine;

namespace ServiceLocatorExample
{
    public enum AudioType
    {
        None = 0,
        AudioSound1,
        AudioSound2
    }

    public interface IAudioPlayer : IService //Note: the service binding happens with the interface.
    {
        void PlaySound(AudioType type);
    }

    /// <summary>
    ///     Class that plays an audio based in its type
    /// </summary>
    public class ServiceAudio : IAudioPlayer
    {
        public void PlaySound(AudioType type)
        {
            Debug.Log($"Played Sound: {type}");
        }
    }
}