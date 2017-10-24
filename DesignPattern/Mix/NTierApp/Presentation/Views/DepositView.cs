using System;
using DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Views
{
    public class DepositView: IView
    {

        private DepositResult Data { get; }

        public DepositView(DepositResult data)
        {

            if (data == null)
                throw new ArgumentNullException(nameof(data));

            Data = data;

        }

        public void Render()
        {
            Console.WriteLine($"User {Data.Username} has deposited " +
                $"{Data.Amount:C2}; {Data.Balance:C2} available.");
        }
    }
}
