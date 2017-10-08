using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Structural
{
    public static class Patterns
    {
        public static List<IDemo> List => new List<IDemo>()
            {
                new Adapter.Demo(),
                new Bridge.Demo(),
                new Composite.Demo(),
                new Decorator.Demo(),
                new Facade.Demo(),
                new Flyweight.Demo(),
                new Proxy.Demo(),
            };
        public static IEnumerable<IDemo> All =>
           Get.All("DesignPattern.Structural");
    }
}
