using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Mediator.Sample2
{
    public class Demo:IDemo
    {
        public string Name => "Mediator pattern";
        public void Run()
        {
            var mediator = new ConcreteMediator
            {
                Light1 = new Light("Bedroom"),
                Light2 = new Light("Kitchen")
            };

            var turnOnAllLightsCommand = new TurnOnAllLightsCommand(mediator);
            turnOnAllLightsCommand.Execute();
            var turnOffAllLightsCommand = new TurnOffAllLightsCommand(mediator);
            turnOffAllLightsCommand.Execute();
        }

    }
}
