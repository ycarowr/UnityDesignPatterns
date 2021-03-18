using UnityEngine;

namespace ServiceLocatorExample
{
    public enum AchievementType
    {
        None = 0,
        Achievement1,
        Achievement2
    }

    public interface IAchievements : IService //Note: the service binding happens with the interface.
    {
        void Unlock(AchievementType type);
    }

    /// <summary>
    ///     Class that unlocks achievements.
    /// </summary>
    public class ServiceAchievements : IAchievements
    {
        public void Unlock(AchievementType type)
        {
            Debug.Log($"Achievement Unlocked: {type}");
        }
    }
}