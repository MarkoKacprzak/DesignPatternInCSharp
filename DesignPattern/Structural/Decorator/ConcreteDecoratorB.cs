using System;

namespace DesignPattern.Structural.Decorator
{
    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
        }
    }
}
