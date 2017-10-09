using System.Collections.Generic;

namespace DesignPattern.Behavioral.Command.Sample2
{
    public class Sample2: ISample
    {
        public string Name => "Command pattern";
        public void Run()
        {
            var bedroomLight = new Light();
            var kitchenLight = new Light();
            var toggleCommand = new ToggleCommand(bedroomLight);
            var lightSwitch = new Switch(toggleCommand);

            lightSwitch.ExecuteCommand();
            lightSwitch.ExecuteCommand();

            var lights = new List<Light>{
                kitchenLight,
                bedroomLight
            };
            var allLightsCommand = new AllLightsCommand(lights);
            lightSwitch = new Switch(allLightsCommand);
            lightSwitch.ExecuteCommand();
        }
    }
}
