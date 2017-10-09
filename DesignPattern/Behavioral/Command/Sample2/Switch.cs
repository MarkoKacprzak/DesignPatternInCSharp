namespace DesignPattern.Behavioral.Command.Sample2
{
    public class Switch
    {
        private const int invoker = 1;
        private Command command;
        public Switch(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
