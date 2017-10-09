namespace DesignPattern.Behavioral.Command
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Command Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Command pattern";
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create receiver, command, and invoker
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            var invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
