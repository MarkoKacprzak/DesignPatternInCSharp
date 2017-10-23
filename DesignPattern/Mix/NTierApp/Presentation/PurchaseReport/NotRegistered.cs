using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    class NotRegistered : IPurchaseReport
    {
        private readonly string username;

        public NotRegistered(string username)
        {
            this.username = username;
        }
        public string ToUiText() => $"User {username} is not registered.";
    }
}
