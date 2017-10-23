using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    public class DepositCommand: ICommand
    {

        private readonly IApplicationServices appServices;

        public DepositCommand(IApplicationServices appServices)
        {
            this.appServices = appServices;
        }

        public void Execute()
        {

            Console.Write("Enter amount to deposit: ");
            var amount = decimal.Parse(Console.ReadLine());

            appServices.Deposit(amount);
        }
    }
}
