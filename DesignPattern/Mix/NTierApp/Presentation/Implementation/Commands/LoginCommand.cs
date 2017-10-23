using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    internal class LoginCommand: ICommand
    {

        private IApplicationServices appServices;

        public LoginCommand(IApplicationServices appServices)
        {
            this.appServices = appServices;
        }

        public void Execute()
        {

            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            if (appServices.Login(username))
                Console.WriteLine($"User '{username}' is now logged in.");
            else
                Console.WriteLine($"Login failed for user '{username}'.");

        }
    }
}
