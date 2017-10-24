using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class FailedPurchaseView: IView
    {
        public void Render()
        {
            Console.WriteLine("Purchase failed.");
        }
    }
}
