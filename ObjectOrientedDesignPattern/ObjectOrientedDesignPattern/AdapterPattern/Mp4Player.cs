using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Interface;

namespace ObjectOrientedDesignPattern.AdapterPattern
{
    public class Mp4Player : IAdvanceMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            //Do nothing
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Mp4 Player is running. Filename is: {0}", fileName);
        }
    }
}
