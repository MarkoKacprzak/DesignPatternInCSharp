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

        public void Execute()
        {
            appServices.Logout();
            Console.WriteLine("User is now logged out.");
        }
    }
}
