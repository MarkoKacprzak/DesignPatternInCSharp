using System;

namespace DesignPattern.Behavioral.Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ConcreteStrategyB : Strategy
    {
        public override void Execute()
        {
            Console.WriteLine(
              "Called ConcreteStrategyB.Execute()");
        }
    }
}
