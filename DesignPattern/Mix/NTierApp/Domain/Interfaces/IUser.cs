using DesignPattern.Mix.NTierApp.Presentation.Interfaces;
namespace DesignPattern.Mix.NTierApp.Domain.Interfaces
{
    public interface IUser
    {
        string Username { get; }
        void Deposit(decimal amount);
        decimal Balance { get; }
        IPurchaseReport Purchase(IProduct product);
    }
}
