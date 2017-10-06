namespace DesignPattern.Behavioral.Mediator.Sample2
{
    public class TurnOffAllLightsCommand : Command
    {
        private Mediator med;
        public TurnOffAllLightsCommand(Mediator med)
        {
            this.med = med;
        }
        public override void Execute()
        {
            med.TurnOffAllLights();
        }
    }
}
