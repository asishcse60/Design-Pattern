using ObjectOrientedDesignPattern.Command.Interface;

namespace ObjectOrientedDesignPattern.Command
{
    public class TurnTvOff : ICommand
    {
        private IElectronicDevice thElectronicDevice;
        public TurnTvOff(IElectronicDevice electronicDevice)
        {
            thElectronicDevice = electronicDevice;
        }
        public void Execute()
        {
            thElectronicDevice.Off();
        }
    }
}
