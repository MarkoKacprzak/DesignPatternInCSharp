namespace DesignPattern.Creational.Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class Director
    {
        private Builder builder;
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
