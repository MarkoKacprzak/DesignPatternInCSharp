using DesignPattern.Mix.NTierApp.Application.Interfaces;
using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    public class DomainServices: IDomainServices
    {

        private readonly IUserRepository userRepository;
        private readonly IProductRepository productRepository;
        private readonly IPurchaseReportFactory purchaseReportFactory;

        public DomainServices(IUserRepository userRepository, IProductRepository productRepository,
            IPurchaseReportFactory purchaseReportFactory)
        {
            this.userRepository = userRepository;
            this.productRepository = productRepository;
            this.purchaseReportFactory = purchaseReportFactory;
        }

        public void CreateUser(string username)
        {
            var userAccount = new Account();
            var user = new User(username, userAccount, purchaseReportFactory);

            userRepository.Add(user);
        }

        public bool IsRegistered(string username)
        {
            var user = this.userRepository.Find(username);
            return user != null;
        }

        public void Deposit(string username, decimal amount)
        {
            var user = this.userRepository.Find(username);
            user.Deposit(amount);
        }

        public decimal GetBalance(string username)
        {
            var user = this.userRepository.Find(username);
            return user.Balance;
        }

        public IEnumerable<StockItem> GetAvailableItems() =>
            productRepository.GetAll().Select(product => new StockItem(product.Name, product.Price));

        public IPurchaseReport Purchase(string username, string itemName)
        { 
            var product = productRepository.Find(itemName);

            if (product == null)
                return purchaseReportFactory.CreateProductNotFound(username, itemName);

            var user = userRepository.Find(username);

            if (user == null)
                return purchaseReportFactory.CreateNotRegistered(username);

            return user.Purchase(product);
        }
    }
}
