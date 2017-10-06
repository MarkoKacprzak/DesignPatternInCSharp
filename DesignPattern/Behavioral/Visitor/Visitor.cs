namespace DesignPattern.Behavioral.Visitor
{

    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(
          ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
          ConcreteElementB concreteElementB);
    }
}
