namespace DesignPattern.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        private ProductA2 ProductA;
        private ProductB2 ProductB;
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
