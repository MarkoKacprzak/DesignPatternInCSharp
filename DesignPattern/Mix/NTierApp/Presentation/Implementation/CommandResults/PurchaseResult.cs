using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults
{
    public class PurchaseResult: ICommandResult
    {

        public IPurchaseReport Report { get; }

        public PurchaseResult(IPurchaseReport purchaseReport)
        {

            if (purchaseReport == null)
                throw new ArgumentNullException(nameof(purchaseReport));

            Report = purchaseReport;

        } 
    }
}
