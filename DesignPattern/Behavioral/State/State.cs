namespace DesignPattern.Behavioral.State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
