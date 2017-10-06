namespace DesignPattern.Behavioral.Strategy
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Strategy Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Strategy pattern";
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            Context context;
            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.Request();
            context = new Context(new ConcreteStrategyB());
            context.Request();
            context = new Context(new ConcreteStrategyC());
            context.Request();
        }
    }
}
