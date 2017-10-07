namespace DesignPattern.Structural.Adapter
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Adapter Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Adapter pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
        }
    }
}
