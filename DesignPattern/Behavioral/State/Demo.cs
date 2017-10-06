namespace DesignPattern.Behavioral.State
{
    /// <summary>
    /// MainApp startup class for Structural
    /// State Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "State pattern";
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Setup context in a state
            var c = new Context(new ConcreteStateA());
            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}
