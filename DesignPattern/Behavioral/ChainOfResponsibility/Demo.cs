namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Chain of Responsibility Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Chain of responsibility pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Setup Chain of Responsibility
            var h1 = new ConcreteHandler1();
            var h2 = new ConcreteHandler2();
            var h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }
        }
    }
}
