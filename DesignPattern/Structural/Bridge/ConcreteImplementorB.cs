using System;

namespace DesignPattern.Structural.Bridge
{
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    public class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}
