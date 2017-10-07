namespace DesignPattern.Structural.Bridge
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class Abstraction
    {
        protected Implementor implementor;

        // Property
        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
