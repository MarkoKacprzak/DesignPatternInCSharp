using DesignPattern.Mix.NTierApp.Common;
using System.Collections.Generic;

namespace DesignPattern.Mix.NTierApp.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<IProduct> GetAll();
        Option<IProduct> TryFind(string name);
    }
}
