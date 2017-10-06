namespace DesignPattern.Behavioral.Visitor
{
    /// <summary>
    /// A 'ConcreteElement' class
    /// </summary>
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
        }
    }
}
