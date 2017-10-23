using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    internal class User: IUser
    {
        public string Username { get; private set; }
        private readonly IAccount account;
        private readonly IPurchaseReportFactory purchaseReportFactory;

        public User(string username, IAccount account,
            IPurchaseReportFactory purchaseReportFactory)
        {
            Username = username;
            this.account = account;
            this.purchaseReportFactory = purchaseReportFactory;
        }

        public void Deposit(decimal amount)
        {
            account.Deposit(amount);
        }

        public decimal Balance => account.Balance;

        public IPurchaseReport Purchase(IProduct product)
        {
            var transaction = account.Withdraw(product.Price);

            if (transaction == null)
                return purchaseReportFactory.CreateNotEnoughMoney(Username, product.Name, product.Price);

            return new Receipt(Username, product.Name, product.Price);
        }
    }
}
