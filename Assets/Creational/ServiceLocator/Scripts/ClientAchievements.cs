namespace ServiceLocatorExample
{
    public class ClientAchievements : ClientBase
    {
        [Button]
        public void UnlockAchievement1()
        {
            UnlockAchievement(AchievementType.Achievement1);
        }

        [Button]
        public void UnlockAchievement2()
        {
            UnlockAchievement(AchievementType.Achievement2);
        }

        private void UnlockAchievement(AchievementType type)
        {
            var achievements = GetService<IAchievements>();
            if (achievements == null)
                Logger.Log("Achievements", $"achievements services not initialized properly for {type}");
            else
                achievements.Unlock(type);
        }
    }
}