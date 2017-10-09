namespace DesignPattern.Behavioral.Command.Sample2
{
    public class OnCommand : Command
    {
        private Light light;
        private const int ConcreteCommand = 1;

        public OnCommand(Light light)
        {
            this.light = light;
        }
        public override void Execute()
        {
            light.On();
        }
    }
}
