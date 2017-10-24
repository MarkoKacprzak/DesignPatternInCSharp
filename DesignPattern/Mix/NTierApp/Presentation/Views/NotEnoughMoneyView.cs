using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class NotEnoughMoneyView: IView
    {

        private NotEnoughtMoney Data { get; }

        public NotEnoughMoneyView(NotEnoughtMoney data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.WriteLine($"Dear {Data.Username},\nYou do not have {Data.Price:C} to pay for the {Data.ProductName}.");
        }
    }
}
