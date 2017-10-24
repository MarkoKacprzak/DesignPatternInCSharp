using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    internal class RegisterCommand: ICommand
    {

        private readonly IApplicationServices appServices;

        public RegisterCommand(IApplicationServices appServices)
        {
            this.appServices = appServices;
        }

        public ICommandResult Execute()
        {
            
            Console.Write("Enter username to register: ");
            var username = Console.ReadLine();

            appServices.RegisterUser(username);

            //Console.WriteLine($"User '{username}' is now registered.");
            return new UserRegistered(username);
        }
    }
}
