namespace DesignPattern.Structural.Flyweight
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Flyweight Design Pattern.
    /// </summary>
    public class Demo : IDemo
    {
        public string Name => "Flyweight pattern";

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;

            var factory = new FlyweightFactory();

            // Work with different flyweight instances
            var fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            var fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            var fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            var fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);
        }
    }
}
