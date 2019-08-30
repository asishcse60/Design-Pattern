using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Interface;

namespace ObjectOrientedDesignPattern.AdapterPattern
{
    public class VlcPlayer : IAdvanceMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Vlc Player is running. File name is: {0}",fileName);
        }

        public void PlayMp4(string fileName)
        {
            //Do nothing
        }
    }
}
