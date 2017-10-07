using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Behavioral
{
    public static class Patterns
    {
        public static List<IDemo> List => new List<IDemo>()
            {
                new ChainOfResponsibility.Demo(),
                new Command.Demo(),
                new Interpreter.Demo(),
                new Iterator.Demo(),
                new Mediator.Demo(),
                new Mediator.Sample2.Demo(),
                new Memento.Demo(),
                new Observer.Demo(),
                new State.Demo(),
                new Strategy.Demo(),
                new TemplateMethod.Demo(),
                new Visitor.Demo(),
            };
        public static IEnumerable<IDemo> All =>
            Get.All("DesignPattern.Behavioral");
    }
}
