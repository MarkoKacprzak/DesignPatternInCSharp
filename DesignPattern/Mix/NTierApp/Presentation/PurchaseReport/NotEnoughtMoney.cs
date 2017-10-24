using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    public class NotEnoughtMoney : IPurchaseReport
    {
        public string Username { get; }
        public decimal Price { get; }
        public string ProductName { get; }

        public NotEnoughtMoney(string username, string productName, decimal price)
        {
            Username = username;
            ProductName = productName;
            Price = price;
        }
    }
}
