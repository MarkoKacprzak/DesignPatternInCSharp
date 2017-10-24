using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
using DesignPattern.Mix.NTierApp.Presentation.PurchaseReport;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class NotRegisteredView: IView
    {

        private NotRegistered Data { get; }

        public NotRegisteredView(NotRegistered data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;
        }

        public void Render()
        {
            Console.Write($"User {Data.Username} is not registered.");
        }
    }
}
