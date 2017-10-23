using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    class PurchaseReportFactory : IPurchaseReportFactory
    {
        public IPurchaseReport CreateFailedPurchase()
            => FailedPurchase.Instance;
        public IPurchaseReport CreateNotEnoughMoney(string username, string productName, decimal price)
            => new NotEnoughtMoney(username, productName, price);
        public IPurchaseReport CreateNotRegistered(string username)
            => new NotRegistered(username);
        public IPurchaseReport CreateNotSignedIn()
            => new NotSignedIn();
        public IPurchaseReport CreateProductNotFound(string username, string productName)
            => new ProductNotFound(username, productName);
        public IPurchaseReport CreateReport(string username, string productName, decimal price)
            => new Receipt(username, productName, price);
    }
}
