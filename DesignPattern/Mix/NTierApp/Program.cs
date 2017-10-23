using DesignPattern.Mix.NTierApp.Application.Implementation;
using DesignPattern.Mix.NTierApp.Domain.Implementation;
using DesignPattern.Mix.NTierApp.Infrastructure.Implementation;
using DesignPattern.Mix.NTierApp.Presentation.Implementation;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;
namespace DesignPattern.Mix.NTierApp
{
    public static class Program
    {
        public static void Run()
        {
            var purchaseReportFactory = new PurchaseReportFactory();

            UserInterface ui =
                new UserInterface(
                    new ApplicationServices(
                        new DomainServices(
                            new UserRepository(),
                            new ProductRepository(),
                            purchaseReportFactory),
                    purchaseReportFactory));

            while (ui.ReadCommand())
            {
                ui.ExecuteCommand();
            }
        }
    }

}
