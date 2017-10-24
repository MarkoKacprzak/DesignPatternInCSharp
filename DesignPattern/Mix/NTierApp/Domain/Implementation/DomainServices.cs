using DesignPattern.Mix.NTierApp.Application.Interfaces;
using DesignPattern.Mix.NTierApp.Common;
using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    public class DomainServices : IDomainServices
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
            => userRepository.Find(username).Any();

        public void Deposit(string username, decimal amount)
            =>
            userRepository.Find(username)
            .ForEach(user => user.Deposit(amount));

        public decimal GetBalance(string username)
            => userRepository
            .Find(username)
            .Select(user => user.Balance)
            .DefaultIfEmpty(0)
            .Single();

        public IEnumerable<StockItem> GetAvailableItems() =>
            productRepository
            .GetAll()
            .Select(product => new StockItem(product.Name, product.Price));

        public IPurchaseReport Purchase(string username, string itemName)
            => productRepository
            .TryFind(itemName)
            .Select(product => Purchase(username, product))
            .DefaultIfEmpty(purchaseReportFactory.CreateProductNotFound(username, itemName))
            .Single();

        private IPurchaseReport Purchase(string username, IProduct product)
            => userRepository.Find(username)
            .Select(user => user.Purchase(product))
            .DefaultIfEmpty(purchaseReportFactory.CreateNotRegistered(username))
            .Single();
    }
}
