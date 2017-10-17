namespace DesignPattern.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        private ProductA1 ProductA;
        private ProductB1 ProductB;

        public ProductA1 ProductA1 { get => ProductA; set => ProductA = value; }
        public ProductB1 ProductB1 { get => ProductB; set => ProductB = value; }

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
