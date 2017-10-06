namespace DesignPattern.Behavioral.Strategy
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {
        private Strategy _strategy;
        // Constructor
        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }
        public void Request()
        {
            _strategy.Execute();
        }
    }
}
