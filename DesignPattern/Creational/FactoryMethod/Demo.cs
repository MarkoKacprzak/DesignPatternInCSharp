using System;

namespace DesignPattern.Creational.FactoryMethod
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Factory Method Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "Factory Method pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // An array of creators
            var creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine($"Created {product.GetType().Name}");
            }
        }
    }
}
