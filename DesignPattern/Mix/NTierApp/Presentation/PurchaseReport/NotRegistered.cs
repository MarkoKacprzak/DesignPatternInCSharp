using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    public class NotRegistered : IPurchaseReport
    {
        public string Username { get; }

        public NotRegistered(string username)
        {
            Username = username;
        }
    }
}
