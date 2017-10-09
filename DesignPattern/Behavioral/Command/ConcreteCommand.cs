namespace DesignPattern.Behavioral.Command
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class ConcreteCommand : Command
    {
        protected Receiver receiver;
        // Constructor
        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
