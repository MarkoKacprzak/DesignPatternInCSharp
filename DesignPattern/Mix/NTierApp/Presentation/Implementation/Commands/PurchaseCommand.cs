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

        public void Execute()
        {

            ShowStock();

            Console.Write("Enter item name: ");
            var itemName = Console.ReadLine();

            var receipt = this.appServices.Purchase(itemName);

            DisplayReport(receipt);
        }

        private void ShowStock()
        {
            Console.WriteLine("Available items:");
            foreach (var item in this.appServices.GetAvailableItems())
                Console.WriteLine("{0,10} {1:C}", item.Name, item.Price);
            Console.WriteLine();
            Console.WriteLine();
        }

        private void DisplayReport(IPurchaseReport report)
        {
            Console.WriteLine(report.ToUiText());
        }
    }
}
