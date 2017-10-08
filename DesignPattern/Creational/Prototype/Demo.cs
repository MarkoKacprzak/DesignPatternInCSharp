using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Prototype Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Prototype pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create two instances and clone each
            var p1 = new ConcretePrototype1("I");
            var c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine($"Cloned: {c1.Id}");

            var p2 = new ConcretePrototype2("II");
            var c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine($"Cloned: {c2.Id}");            
        }
    }
}
