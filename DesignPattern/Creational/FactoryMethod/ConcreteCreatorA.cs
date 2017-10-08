namespace DesignPattern.Creational.FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteCreatorA : Creator
    {
        private ConcreteProductA product;
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
