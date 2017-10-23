using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using System.Collections.Generic;

namespace DesignPattern.Mix.NTierApp.Application.Interfaces
{
    public interface IDomainServices
    {
        void CreateUser(string username);
        bool IsRegistered(string username);
        void Deposit(string username, decimal amount);
        decimal GetBalance(string username);
        IEnumerable<StockItem> GetAvailableItems();
        Receipt Purchase(string username, string itemName);
    }
}
