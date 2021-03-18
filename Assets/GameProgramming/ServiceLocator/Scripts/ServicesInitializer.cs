using UnityEngine;

namespace ServiceLocatorExample
{
    /// <summary>
    ///     Passes all the necessary services.
    /// </summary>
    public class ServicesInitializer : MonoBehaviour
    {
        private void Awake()
        {
            var logger = new ServiceLogger();
            var audioPlayer = new ServiceAudio();
            var achievements = new ServiceAchievements();
            
            //Note: the binding happens with the interface.
            ServiceLocator.RegisterService<ILogger>(logger);
            ServiceLocator.RegisterService<IAudioPlayer>(audioPlayer);
            ServiceLocator.RegisterService<IAchievements>(achievements);
            
            logger.Log("Services", "Initialized successfully");
        }
    }
}