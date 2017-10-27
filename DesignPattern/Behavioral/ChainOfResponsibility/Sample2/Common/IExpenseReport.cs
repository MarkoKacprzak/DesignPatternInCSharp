using System;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Sample2.Common
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }
}