using DesignPattern.Behavioral.Command.Logging.Commands;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral.Command.Logging
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];

            var command = FindRequestedCommand(requestedCommandName);

            return command.MakeCommand(args);
        }

        ICommandFactory FindRequestedCommand(string commandName)
            => availableCommands
                .Where(cmd => cmd.CommandName == commandName)
                .DefaultIfEmpty(new NotFoundCommand(commandName))
                .Single();
    }
}