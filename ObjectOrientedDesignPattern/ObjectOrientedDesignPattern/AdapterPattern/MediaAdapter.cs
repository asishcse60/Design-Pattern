using ObjectOrientedDesignPattern.AdapterPattern.Interface;
using ObjectOrientedDesignPattern.Interface;

namespace ObjectOrientedDesignPattern.AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvanceMediaPlayer advanceMediaPlayer;
        public MediaAdapter(string audioType)
        {
            if(audioType == "vlc")
                advanceMediaPlayer = new VlcPlayer();
            else if(audioType == "mp4")
            {
                advanceMediaPlayer = new Mp4Player();
            }
        }
        public void Play(string audioType, string fileName)
        {
           if(audioType == "vlc")
               advanceMediaPlayer.PlayVlc(fileName);
           else if (audioType == "mp4")
           {
               advanceMediaPlayer.PlayMp4(fileName);
           }
        }
    }
}
