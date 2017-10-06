namespace DesignPattern.Behavioral.Iterator
{
    public abstract class Client<T> where T:class
    {
        private Aggregate<T> expression=null;
        private Iterator<T> context = null;

        public Aggregate<T> Expression { get => expression; set => expression = value; }
        public Iterator<T> Context { get => context; set => context = value; }
    }
}
