using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    public class Receipt: IPurchaseReport
    {
        private readonly string username;
        private readonly string itemName;
        private readonly decimal price;

        public Receipt(string username, string itemName, decimal price)
        {
            this.username = username;
            this.itemName = itemName;
            this.price = price;
        }

        public string ToUiText() => $"Thank you for buying {itemName} for {price:C}";
    }
}
