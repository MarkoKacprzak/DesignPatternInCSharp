namespace DesignPattern.Behavioral.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
