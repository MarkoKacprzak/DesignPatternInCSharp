using System;

namespace DesignPattern.Behavioral.Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ConcreteStrategyC : Strategy
    {
        public override void Execute()
        {
            Console.WriteLine(
              "Called ConcreteStrategyC.Execute()");
        }
    }
}
