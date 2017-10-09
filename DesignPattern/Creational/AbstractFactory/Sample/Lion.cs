using System;

namespace DesignPattern.Creational.AbstractFactory.Sample
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}");
        }
    }
}
