using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.AdapterPattern.Interface;
using ObjectOrientedDesignPattern.Interface;

namespace ObjectOrientedDesignPattern.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;
        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine("AudioPlayer mp3 is running. File name is: {0}", fileName);
            }
            else if(audioType.Equals("vlc"))
            {
                mediaAdapter = new MediaAdapter("vlc");
                mediaAdapter.Play(audioType, fileName);
            }
            else if(audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter("mp4");
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. {0} format is not supported.", audioType);
            }
        }
    }
}
