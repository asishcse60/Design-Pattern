using System;
using ObjectOrientedDesignPattern.Command.Interface;

namespace ObjectOrientedDesignPattern.Command
{
    public class Television:IElectronicDevice
    {
        private int _volume = 0;    
        public void On()
        {
            Console.WriteLine("TV is On");
        }

        public void Off()
        {
            Console.WriteLine("TV is Off");
        }

        public void VolumeUp()
        {
            _volume++;
            Console.WriteLine("VolumeUp is Up: {0}", _volume);
        }

        public void VolumeDown()
        {
            _volume--;
            Console.WriteLine("VolumeUp is Down: {0}", _volume);
        }
    }
}
