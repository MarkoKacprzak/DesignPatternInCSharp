using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    internal class LogoutCommand: ICommand
    {

        private IApplicationServices appServices;

        public LogoutCommand(IApplicationServices appServices)
        {
            this.appServices = appServices;
        }

        public ICommandResult Execute()
        {
            string username = appServices.LoggedInUsername;
            appServices.Logout();
            //Console.WriteLine("User is now logged out.");
            return new UserLoggedOut(username);
        }
    }
}
