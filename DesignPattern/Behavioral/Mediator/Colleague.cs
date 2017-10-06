namespace DesignPattern.Behavioral.Mediator
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator mediator;

        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
