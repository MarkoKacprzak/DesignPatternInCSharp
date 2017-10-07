using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Decorator
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Decorator Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Decorator pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create ConcreteComponent and two Decorators
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();
        }
    }
}
