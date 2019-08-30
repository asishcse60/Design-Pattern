using ObjectOrientedDesignPattern.Command.Interface;

namespace ObjectOrientedDesignPattern.Command
{
    public class TvVolumeDown : ICommand
    {
        private IElectronicDevice electronicDevice;

        public TvVolumeDown(IElectronicDevice newDevice)
        {
            electronicDevice = newDevice;
        }
        public void Execute()
        {
           electronicDevice.VolumeDown();
        }
    }
}
