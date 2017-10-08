namespace DesignPattern.Creational.Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
