using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;
using System.Linq;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    internal class User : IUser
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
            => account.TryWithdraw(product.Price)
                .Select(trans => new Receipt(Username, product.Name, product.Price))
                .DefaultIfEmpty(NotEnoughtMoneyReport(product.Name, product.Price))
                .Single();
        private IPurchaseReport NotEnoughtMoneyReport(string productName, decimal price)
            => purchaseReportFactory.CreateNotEnoughMoney(Username, productName, price);
    }
}
