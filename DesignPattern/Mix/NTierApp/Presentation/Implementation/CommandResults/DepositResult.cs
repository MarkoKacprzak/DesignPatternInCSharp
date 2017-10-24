using System;
using DesignPattern.Mix.NTierApp.Presentation.Interfaces;

namespace DesignPattern.Mix.NTierApp.Presentation.Implementation.CommandResults
{
    public class DepositResult: ICommandResult
    {
        public string Username { get; }
        public decimal Amount { get; }
        public decimal Balance { get; }

        public DepositResult(string username, decimal amount, decimal balance)
        {
            Username = username ?? string.Empty;
            Amount = amount;
            Balance = balance;
        }
    }
}
