using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedDesignPattern.Command.Interface;

namespace ObjectOrientedDesignPattern.Command
{
    public class TvVolumeUp : ICommand
    {
        private IElectronicDevice theDevice;
        public TvVolumeUp(IElectronicDevice electronicDevice)
        {
            theDevice = electronicDevice;
        }
        public void Execute()
        {
           theDevice.VolumeUp();
        }
    }
}
