namespace DesignPattern.Behavioral.TemplateMethod
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Template Design Pattern.
    /// </summary>
    public class Demo:IDemo
    {
        public string Name => "TemplateMethod pattern";
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            var aA = new ConcreteClassA();
            aA.TemplateMethod();

            var aB = new ConcreteClassB();
            aB.TemplateMethod();
        }
    }
}
