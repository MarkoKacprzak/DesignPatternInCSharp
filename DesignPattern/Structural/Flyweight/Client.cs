namespace DesignPattern.Structural.Flyweight
{
    public class Client
    {
        FlyweightFactory factory;
        UnsharedConcreteFlyweight flyweight1;
        ConcreteFlyweight flyweight2;

        public FlyweightFactory Factory { get => factory; set => factory = value; }
        public UnsharedConcreteFlyweight Flyweight1 { get => flyweight1; set => flyweight1 = value; }
        public ConcreteFlyweight Flyweight2 { get => flyweight2; set => flyweight2 = value; }
    }
}
