using System.Collections.Generic;

namespace DesignPattern.Mix.NTierApp.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<IProduct> GetAll();
        IEnumerable<IProduct> Find(string name);
    }
}
