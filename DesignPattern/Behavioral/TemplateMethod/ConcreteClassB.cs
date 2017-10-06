using System;

namespace DesignPattern.Behavioral.TemplateMethod
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class ConcreteClassB : AbstractClass
    {
        public override void SubMethod1()
        {
            Console.WriteLine("ConcreteClassB.SubMethod1()");
        }
        public override void SubMethod2()
        {
            Console.WriteLine("ConcreteClassB.SubMethod2()");
        }
    }
}
