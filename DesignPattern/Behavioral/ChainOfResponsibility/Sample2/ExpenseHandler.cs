using DesignPattern.Behavioral.ChainOfResponsibility.Sample2.Common;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample2
{
    class ExpenseHandler : IExpenseHandler
    {
        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            ApprovalResponse response = _approver.ApproveExpense(expenseReport);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expenseReport);
            }

            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }

        private readonly IExpenseApprover _approver;
        private IExpenseHandler _next;
    }
}