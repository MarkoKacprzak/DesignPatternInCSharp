using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    class NotEnoughtMoney : IPurchaseReport
    {
        private readonly string username;
        private readonly string productName;
        private readonly decimal price;

        public NotEnoughtMoney(string username,string productName, decimal price)
        {
            this.username = username;
            this.productName = productName;
            this.price = price;
        }
        public string ToUiText() => $"Dear {username}\n" +
            $"You do not have {price:C} to pay for the {productName}.";
    }
}
