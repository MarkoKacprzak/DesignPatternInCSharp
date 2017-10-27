using DesignPattern.Mix.NTierApp.Common;
using DesignPattern.Mix.NTierApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Mix.NTierApp.Domain.Implementation
{
    class CreditAccount : AccountBase
    {
        private readonly IList<MoneyTransaction> pendingTransactions = new List<MoneyTransaction>();

        private readonly bool strictTransactionOrder;

        public CreditAccount(bool strictTransactionsOrder)
        {
            strictTransactionOrder = strictTransactionsOrder;
        }
        public override decimal Balance
            => base.Balance + pendingTransactions.Sum(trans => trans.Amount);
         
        public override Option<MoneyTransaction> TryWithdraw(decimal amount)
        {

            if (amount <= 0)
                throw new ArgumentException("Amount to withdraw must be positive.", nameof(amount));

            MoneyTransaction transaction = new MoneyTransaction(-amount);

            if (Balance >= amount)
                RegisterTransaction(transaction);
            else
                pendingTransactions.Add(transaction);

            return Option<MoneyTransaction>.Create(transaction);

        }

        public override MoneyTransaction Deposit(decimal amount)
        {

            if (amount <= 0)
                throw new ArgumentException("Amount to deposit must be positive.", nameof(amount));

            MoneyTransaction transaction = new MoneyTransaction(amount);
            RegisterTransaction(transaction);

            ProcessPendingWithdrawals();

            return transaction;
        }
        private void ProcessPendingWithdrawals()
        {

            var option = Option<MoneyTransaction>.CreateEmpty();

            do
            {
                option = TrySelectPendingTransaction();
                ProcessPendingWithdrawal(option);
            }
            while (option.Any());

        }

        private Option<MoneyTransaction> TrySelectPendingTransaction()
        {
            if (strictTransactionOrder)
                return TrySelectFirstPendingTransaction();
            else
                return TrySelectConformingPendingTransaction();
        }

        private void ProcessPendingWithdrawal(Option<MoneyTransaction> option)
        {

            if (!option.Any())
                return;

            var transaction = option.Single();

            RegisterTransaction(transaction);
            pendingTransactions.Remove(transaction);

        }

        private Option<MoneyTransaction> TrySelectFirstPendingTransaction()
        {

            if (!pendingTransactions.Any())
                return Option<MoneyTransaction>.CreateEmpty();

            MoneyTransaction candidate = pendingTransactions.First();

            if (base.Balance + candidate.Amount < 0)
                return Option<MoneyTransaction>.CreateEmpty();

            return Option<MoneyTransaction>.Create(candidate);

        }

        private Option<MoneyTransaction> TrySelectConformingPendingTransaction()
        {
            return
                pendingTransactions
                    .Where(trans => base.Balance + trans.Amount >= 0)
                    .Take(1)
                    .Select(trans => Option<MoneyTransaction>.Create(trans))
                    .DefaultIfEmpty(Option<MoneyTransaction>.CreateEmpty())
                    .Single();
        }

    }
}
