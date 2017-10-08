using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Abstract Factory Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Abstract Factory pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Abstract factory #1
            var factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            var factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);
            client2.Run();
        }
    }
}
