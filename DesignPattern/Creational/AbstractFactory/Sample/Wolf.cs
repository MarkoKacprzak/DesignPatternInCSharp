using System;

namespace DesignPattern.Creational.AbstractFactory.Sample
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}");
        }
    }
}
