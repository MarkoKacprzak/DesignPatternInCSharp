using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    public class FailedPurchase : IPurchaseReport
    {
        private static FailedPurchase instance;
        private FailedPurchase()
        {
        }
        public static FailedPurchase Instance
        {
            get
            {
                if (instance == null)
                    instance = new FailedPurchase();
                return instance;
            }
        }
    }
}
