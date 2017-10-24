using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    public class ProductNotFound : IPurchaseReport
    {
        public string Username { get; }
        public string ProductName { get; }
        public ProductNotFound(string username, string productName)
        {
            Username = username;
            ProductName = productName;
        }
    }
}
