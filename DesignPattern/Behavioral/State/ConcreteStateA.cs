namespace DesignPattern.Behavioral.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
