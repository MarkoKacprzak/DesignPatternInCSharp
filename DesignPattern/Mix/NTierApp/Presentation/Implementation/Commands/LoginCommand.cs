using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
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

        public ICommandResult Execute()
        {

            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            if (appServices.Login(username))
                return new UserLoggedIn(username,
                    appServices.LoggedInUserBalance);

            return new LoginFailed(username);
        }
    }
}
