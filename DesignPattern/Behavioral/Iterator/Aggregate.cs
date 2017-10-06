namespace DesignPattern.Behavioral.Iterator
{
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    public abstract class Aggregate<T> where T : class
    {
        public abstract Iterator<T> CreateIterator();
    }
}
