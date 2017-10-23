using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    internal class User: IUser
    {
        public string Username { get; private set; }
        private readonly IAccount account;

        public User(string username, IAccount account)
        {
            Username = username;
            this.account = account;
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
                return FailedPurchase.Instance;

            return new Receipt(product.Name, product.Price);
        }
    }
}
