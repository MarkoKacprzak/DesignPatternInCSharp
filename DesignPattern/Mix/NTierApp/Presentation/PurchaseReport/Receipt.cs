using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    public class Receipt: IPurchaseReport
    {
        public string Username { get; }
        public string ProductName { get; }
        public decimal Price { get; }

        public Receipt(string username, string itemName, decimal price)
        {
            Username = username;
            ProductName = itemName;
            Price = price;
        }

    }
}
