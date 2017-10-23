using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    internal class Account: IAccount
    { 
        private IList<MoneyTransaction> transactions = new List<MoneyTransaction>();

        public MoneyTransaction Deposit(decimal amount)
        {
            var trans = new MoneyTransaction(amount);
            transactions.Add(trans);
            return trans;
        }

        public MoneyTransaction Withdraw(decimal amount)
        {
            if (Balance < amount)
                return null;

            var trans = new MoneyTransaction(-amount);
            transactions.Add(trans);

            return trans;
        }

        public decimal Balance => transactions.Sum(trans => trans.Amount);
    }
}
