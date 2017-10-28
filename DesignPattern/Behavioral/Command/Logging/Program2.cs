using DesignPattern.Behavioral.Command.Logging.Commands;
using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Command.Logging
{
    public class Program2
    {
        public static void Run(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if (args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);

            command.Execute();
        }

        static IEnumerable<ICommandFactory> GetAvailableCommands()
            => new ICommandFactory[]
                {
                    new CreateOrderCommand(),
                    new UpdateQuantityCommand(),
                    new ShipOrderCommand(),
                };

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage: App CommandName Arguments");
            Console.WriteLine("Commands:");
            foreach (var command in availableCommands)
                Console.WriteLine($"  {command.Description}");
        }
    }
}
