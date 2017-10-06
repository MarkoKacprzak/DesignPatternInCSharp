using System;

namespace DesignPattern.Behavioral.Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        public override void Execute()
        {
            Console.WriteLine(
              "Called ConcreteStrategyA.Execute()");
        }
    }
}
