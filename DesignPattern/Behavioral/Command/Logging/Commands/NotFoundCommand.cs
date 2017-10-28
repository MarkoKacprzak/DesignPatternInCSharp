using System;

namespace DesignPattern.Behavioral.Command.Logging.Commands
{
    public class NotFoundCommand : ICommand, ICommandFactory
    {
        public string Name { get; set; }
        public NotFoundCommand(string name)
        {
            Name = name;
        }
        public string CommandName => Name;

        public string Description => Name;

        public void Execute()
        {
            Console.WriteLine("Couldn't find command: " + Name);
        }

        public ICommand MakeCommand(string[] arguments)
            => new NotFoundCommand(arguments[0]);
    }
}