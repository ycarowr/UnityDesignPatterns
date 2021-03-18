namespace ServiceLocatorExample
{
    public class ClientAudio : ClientBase
    {
        [Button]
        public void PlayAudio1()
        {
            PlayAudio(AudioType.AudioSound1);
        }

        [Button]
        public void PlayAudio2()
        {
            PlayAudio(AudioType.AudioSound2);
        }

        private void PlayAudio(AudioType type)
        {
            var audioPlayer = GetService<IAudioPlayer>();
            if (audioPlayer == null)
                Logger.Log("Audio", $"Audio services not initialized properly for {type}");
            else
                audioPlayer.PlaySound(type);
        }
    }
}