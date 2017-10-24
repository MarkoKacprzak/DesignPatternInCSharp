using DesignPattern.Mix.NTierApp.Application.Implementation;
using DesignPattern.Mix.NTierApp.Domain.Implementation;
using DesignPattern.Mix.NTierApp.Infrastructure.Implementation;
using DesignPattern.Mix.NTierApp.Presentation.Implementation;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;
using DesignPattern.Mix.NTierApp.Presentation.Views;

namespace DesignPattern.Mix.NTierApp
{
    public static class Program
    {
        static bool Selector<TCommand>(ICommandResult cmdResult) where TCommand: ICommandResult
            => cmdResult != null && cmdResult.GetType() == typeof(TCommand);

        static bool PurchaseSelector<TPurchaseReport>(ICommandResult cmdResult) 
            where TPurchaseReport: IPurchaseReport
        {
            var purchaseReport = cmdResult as PurchaseResult;
            if (purchaseReport == null)
                return false;
            return purchaseReport.Report.GetType() == typeof(TPurchaseReport);
        }
        static TPurchaseReport Cast<TPurchaseReport>(ICommandResult cmdResult)
            where TPurchaseReport : IPurchaseReport
        {
            var purchaseReport = cmdResult as PurchaseResult;
            if (purchaseReport == null)
                return default(TPurchaseReport);
            var report = purchaseReport.Report;
            return (TPurchaseReport)report;
        }
        private static ViewLocator SetupViewLocator()
        {
            var viewLocator = new ViewLocator();
            viewLocator.RegisterService(Selector<DepositResult>, obj => new DepositView((DepositResult)obj));
            viewLocator.RegisterService(Selector<LoginFailed>, obj => new LoginFailedView((LoginFailed)obj));
            viewLocator.RegisterService(Selector<UserLoggedIn>, obj => new UserLoggedInView((UserLoggedIn)obj));
            viewLocator.RegisterService(Selector<UserLoggedOut>, obj => new UserLoggedOutView((UserLoggedOut)obj));
            viewLocator.RegisterService(Selector<UserRegistered>, obj => new UserRegisteredView((UserRegistered)obj));

            viewLocator.RegisterService(PurchaseSelector<FailedPurchase>, obj => new FailedPurchaseView());
            viewLocator.RegisterService(PurchaseSelector<NotEnoughtMoney>, obj => new NotEnoughMoneyView(Cast<NotEnoughtMoney>(obj)));
            viewLocator.RegisterService(PurchaseSelector<NotSignedIn>, obj => new NotSignedInView());
            viewLocator.RegisterService(PurchaseSelector<ProductNotFound>, obj => new ProductNotFoundView(Cast<ProductNotFound>(obj)));
            viewLocator.RegisterService(PurchaseSelector<Receipt>, obj => new ReceiptView(Cast<Receipt>(obj)));
            return viewLocator;
        }
        public static void Run()
        {
            var purchaseReportFactory = new PurchaseReportFactory();

            var viewLocator = SetupViewLocator();
            UserInterface ui =
                new UserInterface(
                    new ApplicationServices(
                        new DomainServices(
                            new UserRepository(),
                            new ProductRepository(),
                            purchaseReportFactory),
                    purchaseReportFactory), viewLocator);

            while (ui.ReadCommand())
            {
                ui.ExecuteCommand();
            }
        }
    }

}
