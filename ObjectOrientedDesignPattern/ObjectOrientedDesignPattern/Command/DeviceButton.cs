using ObjectOrientedDesignPattern.Command.Interface;

namespace ObjectOrientedDesignPattern.Command
{
    public class DeviceButton
    {
        private ICommand theCommand;

        public DeviceButton(ICommand command)
        {
            theCommand = command;
        }

        public void PressButton()
        {
            theCommand.Execute();
        }

    }
}
