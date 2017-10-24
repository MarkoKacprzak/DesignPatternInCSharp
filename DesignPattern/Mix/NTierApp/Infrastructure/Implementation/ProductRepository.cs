using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.NTierApp.Infrastructure.Implementation
{
    public class ProductRepository: IProductRepository
    {

        private IDictionary<string, decimal> nameToPrice;

        public ProductRepository()
        {
            nameToPrice = new Dictionary<string, decimal>
            {
                { "book", 27.46M },
                { "pen", 6.28M },
                { "ruler", 2.86M }
            };
        }

        public IEnumerable<IProduct> GetAll()
        {
            return nameToPrice.Select(pair => new ProductData(pair.Key, pair.Value));
        }

        public IEnumerable<IProduct> Find(string name)
        {
            if (nameToPrice.TryGetValue(name, out decimal price))
                return new IProduct[] { new ProductData(name, price) };
            return new IProduct[0];
        }
    }
}
