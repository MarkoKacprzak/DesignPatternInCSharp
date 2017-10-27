using DesignPattern.Mix.NTierApp.Common;
using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    internal abstract class AccountBase : IAccount
    {
        private IList<MoneyTransaction> registeredTransactions = new List<MoneyTransaction>();
        public virtual decimal Balance => registeredTransactions.Sum(trans => trans.Amount);

        public abstract MoneyTransaction Deposit(decimal amount);
        protected void RegisterTransaction(MoneyTransaction trans)
        {
            registeredTransactions.Add(trans);
        }
        public abstract Option<MoneyTransaction> TryWithdraw(decimal amount);

    }
}
