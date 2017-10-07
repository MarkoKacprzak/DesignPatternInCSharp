using System;

namespace DesignPattern.Structural.Bridge
{
    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}
