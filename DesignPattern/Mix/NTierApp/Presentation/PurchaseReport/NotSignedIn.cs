using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.PurchaseReport
{
    class NotSignedIn : IPurchaseReport
    {
        public string ToUiText() => "No user is signed in.";
    }
}
