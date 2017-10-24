using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.Commands
{
    internal class PurchaseCommand: ICommand
    {

        private readonly IApplicationServices appServices;

        public PurchaseCommand(IApplicationServices appServices)
        {
            this.appServices = appServices;
        }

        public ICommandResult Execute()
        {

            ShowStock();

            Console.Write("Enter item name: ");
            var itemName = Console.ReadLine();

            var report = this.appServices.Purchase(itemName);
            return new PurchaseResult(report);
            //DisplayReport(receipt);
        }

        private void ShowStock()
        {
            Console.WriteLine("Available items:");
            foreach (var item in this.appServices.GetAvailableItems())
                Console.WriteLine("{0,10} {1:C}", item.Name, item.Price);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
