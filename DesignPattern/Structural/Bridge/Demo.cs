namespace DesignPattern.Structural.Bridge
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Bridge Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Bridge pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            var ab = new RefinedAbstraction
            {
                // Set implementation and call
                Implementor = new ConcreteImplementorA()
            };
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
        }
    }
}
