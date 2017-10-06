namespace DesignPattern.Behavioral.Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class ConcreteIterator<T> : Iterator<T> where T : class
    {
        private ConcreteAggregate<T> _aggregate;
        private int _current = 0;

        // Constructor
        public ConcreteIterator(ConcreteAggregate<T> aggregate)
        {
            this._aggregate = aggregate;
        }

        // Gets first iteration item
        public override T First()
        {
            _current = 0;
            return _aggregate[_current];
        }

        // Gets next iteration item
        public override T Next()
        {
            T ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        // Gets current iteration item
        public override T CurrentItem() =>
            _aggregate[_current];        

        // Gets whether iterations are complete
        public override bool IsDone() =>
            _current+1 >= _aggregate.Count;
        
    }
}
