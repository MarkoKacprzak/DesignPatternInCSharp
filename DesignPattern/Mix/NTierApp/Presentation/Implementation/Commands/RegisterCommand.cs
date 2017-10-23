using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    internal class RegisterCommand: ICommand
    {

        private readonly IApplicationServices appServices;

        public RegisterCommand(IApplicationServices appServices)
        {
            this.appServices = appServices;
        }

        public void Execute()
        {
            
            Console.Write("Enter username to register: ");
            var username = Console.ReadLine();

            appServices.RegisterUser(username);

            Console.WriteLine($"User '{username}' is now registered.");

        }
    }
}
