namespace DesignPattern.Mix.NTierApp.Presentation.Interfaces
{
    public class Receipt: IPurchaseReport
    {
        public string ItemName { get; private set; }
        public decimal Price { get; private set; }

        public Receipt(string itemName, decimal price)
        {
            this.ItemName = itemName;
            this.Price = price;
        }

        public string ToUiText() => $"Thank you for buying {ItemName} for {Price:C}";
    }
}
