using DesignPattern.Behavioral.ChainOfResponsibility.Sample2.Common;
using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample2
{
    class EndOfChainExpenseHandler : IExpenseHandler
    {
        private EndOfChainExpenseHandler() { }

        public static EndOfChainExpenseHandler Instance
            => _instance; 

        public ApprovalResponse Approve(IExpenseReport expenseReport)
            => ApprovalResponse.Denied;

        public void RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }

        private static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();
    }
}