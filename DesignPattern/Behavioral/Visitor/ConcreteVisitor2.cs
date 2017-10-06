using System;

namespace DesignPattern.Behavioral.Visitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(
          ConcreteElementA concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name} " +
                $"visited by {GetType().Name}");
        }

        public override void VisitConcreteElementB(
          ConcreteElementB concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name} " +
                $"visited by {GetType().Name}");
        }
    }
}
