using System.Collections.Generic;

namespace DesignPattern.Behavioral.Command
{
    public class AllLightsCommand : Command
    {
        private List<Light> lights;
        private const int ConcreteCommand = 1;

        public AllLightsCommand(List<Light> lights)
        {
            this.lights = lights;
        }
        public override void Execute()
        {
            foreach (var light in lights)
            {
                light.Toggle();
            }
        }
    }
}
