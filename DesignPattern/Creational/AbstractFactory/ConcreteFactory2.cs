namespace DesignPattern.Creational.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        private ProductA2 ProductA;
        private ProductB2 ProductB;

        public ProductA2 ProductA1 { get => ProductA; set => ProductA = value; }
        public ProductB2 ProductB1 { get => ProductB; set => ProductB = value; }

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
