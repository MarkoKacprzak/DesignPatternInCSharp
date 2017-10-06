using System;

namespace DesignPattern.Behavioral.TemplateMethod
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class ConcreteClassA : AbstractClass
    {
        public override void SubMethod1()
        {
            Console.WriteLine("ConcreteClassA.SubMethod1()");
        }
        public override void SubMethod2()
        {
            Console.WriteLine("ConcreteClassA.SubMethod2()");
        }
    }
}
