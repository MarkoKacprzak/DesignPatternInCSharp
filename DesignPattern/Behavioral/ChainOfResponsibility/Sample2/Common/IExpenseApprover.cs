namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample2.Common
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }
}