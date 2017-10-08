namespace DesignPattern.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        private ProductA1 ProductA;
        private ProductB1 ProductB;
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
