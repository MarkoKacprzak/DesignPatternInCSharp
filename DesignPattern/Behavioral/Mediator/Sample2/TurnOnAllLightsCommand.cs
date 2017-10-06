namespace DesignPattern.Behavioral.Mediator.Sample2
{
    public class TurnOnAllLightsCommand : Command
    {
        private Mediator med;
        public TurnOnAllLightsCommand(Mediator med)
        {
            this.med = med;
        }
        public override void Execute()
        {
            med.TurnOnAllLights();
        }
    }
}
