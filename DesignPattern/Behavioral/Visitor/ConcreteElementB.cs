namespace DesignPattern.Behavioral.Visitor
{
    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
        }
    }
}
