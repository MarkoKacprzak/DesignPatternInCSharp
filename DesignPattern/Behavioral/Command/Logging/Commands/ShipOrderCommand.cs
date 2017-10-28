using System;

namespace DesignPattern.Behavioral.Command.Logging.Commands
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
        }

        public string CommandName
        {
            get { return "ShipOrder"; }
        }

        public string Description
        {
            get { return CommandName; }
        }

        public ICommand MakeCommand(string[] arguments)
            => new ShipOrderCommand();
    }
}