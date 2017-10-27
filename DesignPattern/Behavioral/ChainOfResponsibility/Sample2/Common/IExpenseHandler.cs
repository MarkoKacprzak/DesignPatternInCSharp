namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample2.Common
{
    interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler next);
    }
}