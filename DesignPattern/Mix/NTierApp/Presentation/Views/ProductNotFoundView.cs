using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class ProductNotFoundView: IView
    {
        private ProductNotFound Data { get; }

        public ProductNotFoundView(ProductNotFound data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.WriteLine($"Dear {Data.Username},\nSorry to inform you that we have no {Data.ProductName} left.");
        }
    }
}
