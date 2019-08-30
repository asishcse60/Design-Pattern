using ObjectOrientedDesignPattern.Command.Interface;

namespace ObjectOrientedDesignPattern.Command
{
    public class TurnTvOn : ICommand
    {
        private IElectronicDevice thElectronicDevice;
        public TurnTvOn(IElectronicDevice electronicDevice)
        {
            thElectronicDevice = electronicDevice;
        }

        public void Execute()
        {
           thElectronicDevice.On();
        }
    }
}
