namespace DesignPattern.Behavioral.Visitor
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Visitor Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Visitor pattern";
        public void Run()
        {
            // Setup structure
            var o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());
            // Create visitor objects
            var v1 = new ConcreteVisitor1();
            var v2 = new ConcreteVisitor2();
            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);
        }
    }
}
