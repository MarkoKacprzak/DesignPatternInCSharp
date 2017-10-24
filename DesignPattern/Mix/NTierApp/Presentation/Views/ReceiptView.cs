using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class ReceiptView: IView
    {

        private Receipt Data { get; }

        public ReceiptView(Receipt data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.WriteLine($"Dear {Data.Username},\nThank you for buying {Data.ProductName} for {Data.Price:C}.");
        }
    }
}
