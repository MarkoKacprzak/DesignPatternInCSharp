namespace DesignPattern.Behavioral.Mediator.Sample2
{
    public class ConcreteMediator : Mediator
    {
        private Light light1;
        private Light light2;

        public Light Light1
        {
            set { light1 = value; }
        }
        public Light Light2
        {
            set { light2 = value; }
        }
        public override void TurnOnAllLights()
        {
            if (!light1.IsOn)
                light1.Toggle();
            if (!light2.IsOn)
                light2.Toggle();
        }
        public override void TurnOffAllLights()
        {
            if (light1.IsOn)
                light1.Toggle();
            if (light2.IsOn)
                light2.Toggle();
        }
    }
}
