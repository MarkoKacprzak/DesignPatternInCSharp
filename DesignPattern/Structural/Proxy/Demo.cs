namespace DesignPattern.Structural.Proxy
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Proxy Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Proxy pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create proxy and request a service
            var proxy = new Proxy();
            proxy.Request();
        }
    }
}
