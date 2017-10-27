using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample2.Common
{
    public class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(Decimal total)
        {
            Total = total;
        }

        public decimal Total
        {
            get;
            private set;
        }
    }
}