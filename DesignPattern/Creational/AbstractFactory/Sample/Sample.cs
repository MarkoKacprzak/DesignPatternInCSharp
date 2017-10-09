namespace DesignPattern.Creational.AbstractFactory.Sample
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Abstract Factory Design Pattern.
    /// </summary>
    public class Sample:ISample
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Create and run the African animal world
            var africa = new AfricaFactory();
            var world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            var america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}
