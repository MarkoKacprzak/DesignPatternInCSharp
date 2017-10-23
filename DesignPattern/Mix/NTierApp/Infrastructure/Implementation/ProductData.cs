using DesignPattern.Mix.NTierApp.Domain.Interfaces;

namespace DesignPattern.Mix.NTierApp.Infrastructure.Implementation
{
    internal class ProductData: IProduct
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public ProductData(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
