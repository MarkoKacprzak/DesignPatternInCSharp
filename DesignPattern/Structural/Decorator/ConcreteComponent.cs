using System;

namespace DesignPattern.Structural.Decorator
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
