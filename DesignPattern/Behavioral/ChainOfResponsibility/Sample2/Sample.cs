using DesignPattern.Behavioral.ChainOfResponsibility.Sample2.Common;
using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample2
{
    public class Sample : ISample
    {
        public void BeforePattern()
        {
            var managers = new List<Employee>
            {
                new Employee("William Worker", Decimal.Zero),
                new Employee("Mary Manager", new Decimal(1000)),
                new Employee("Victor Vicepres", new Decimal(5000)),
                new Employee("Paula President", new Decimal(20000)),
            };

            while (ConsoleInput.TryReadDecimal("Expense report amount:", out decimal expenseReportAmount))
            {
                var expense = new ExpenseReport(expenseReportAmount);
                bool expenseProcessed = false;
                foreach (var approver in managers)
                {
                    var response = approver.ApproveExpense(expense);
                    if (response != ApprovalResponse.BeyondApprovalLimit)
                    {
                        Console.WriteLine($"The request was {response}.");
                        expenseProcessed = true;
                        break;
                    }
                }

                if (!expenseProcessed)
                {
                    Console.WriteLine("No one was able to approve your expense.");
                }
            }
        }
        public void Run()
        {
            var william = new ExpenseHandler(new Employee("William Worker", Decimal.Zero));
            var mary = new ExpenseHandler(new Employee("Mary Manager", new Decimal(1000)));
            var victor = new ExpenseHandler(new Employee("Victor Vicepres", new Decimal(5000)));
            var paula = new ExpenseHandler(new Employee("Paula President", new Decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            if (ConsoleInput.TryReadDecimal("Expense report amount:", out decimal expenseReportAmount))
            {
                var expense = new ExpenseReport(expenseReportAmount);
                var response = william.Approve(expense);
                Console.WriteLine($"The request was {response}.");
            }
        }
    }
}