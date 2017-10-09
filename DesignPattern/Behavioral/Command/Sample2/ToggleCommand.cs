namespace DesignPattern.Behavioral.Command.Sample2
{
    public class ToggleCommand : Command
    {
        private Light light;
        private const int ConcreteCommand = 1;

        public ToggleCommand(Light light)
        {
            this.light = light;
        }
        public override void Execute()
        {
            light.Toggle();
        }
    }
}
