using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    class ProductNotFound : IPurchaseReport
    {
        private readonly string username;
        private readonly string productName;

        public ProductNotFound(string username, string productName)
        {
            this.username = username;
            this.productName = productName;
        }
        public string ToUiText() => $"Dear {username}\n" +
            $"Sorry to inform you that we have no {productName} left.";
    }
}
