using DesignPattern.Mix.NTierApp.Common;

namespace DesignPattern.Mix.NTierApp.Domain.Interfaces
{
    public interface IAccount
    {
        MoneyTransaction Deposit(decimal amount);
        Option<MoneyTransaction> TryWithdraw(decimal amount);
        decimal Balance { get; }
    }
}
