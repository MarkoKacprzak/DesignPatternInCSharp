using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Structural.Flyweight
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();
        private Flyweight flyweight => flyweights["X"];

        // Constructor
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweights[key];
        }
    }
}
