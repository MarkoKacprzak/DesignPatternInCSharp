using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational
{
    public static class Patterns
    {
        public static List<IDemo> List => new List<IDemo>()
            {
                new AbstractFactory.Demo(),
                new Builder.Demo(),
                new FactoryMethod.Demo(),
                new Prototype.Demo(),
                new Singleton.Demo(),
            };
        public static IEnumerable<IDemo> All =>
            Get.All("DesignPattern.Creational");
    }
}
