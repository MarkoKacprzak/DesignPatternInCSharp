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
        public static List<IDemo> All()
        {
            var list = new List<IDemo>();

            var types = System.AppDomain.CurrentDomain.GetAssemblies().ToList()
                .SelectMany(a => a.GetTypes())
                .Where(t => typeof(IDemo).IsAssignableFrom(t))
                .Where(t => t.IsClass)
                .Where(t => t.Namespace.StartsWith("DesignPattern.Behavioral"))
                .OrderBy(t=>t.Namespace);

            foreach (var t in types)
            {
                list.Add((IDemo)System.Activator.CreateInstance(t));
            }
            return list;
        }
    }
}
